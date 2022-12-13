﻿using BancoDeDados.Contexto;
using BancoDeDados.Controller;
using BancoDeDados.Models;
using BancoDeDados.Servicos;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class Login : Form
    {
        private BDContexto _contexto;
        private OperacoesBanco _banco;
        private Servico _servico;
        public Login()
        {
            InitializeComponent();
            _contexto = new BDContexto().getInstancia();
            _banco = new OperacoesBanco();
            _servico = new Servico();
        }
        
        private void menuItemCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (_servico.ExisteAdministrador())
            {
                MessageBox.Show("Existe um Administrador, peça permissão á ele para abrir esta tela!");
                return;
            }
            else if (ExisteUsuarioAtivo())
            {
                MessageBox.Show("Existe pelo menos um usuário ativo, efetue o login");
                return;
            }
            _servico.AbrirTela(new CadastroUsuario());
        }
        private bool ExisteUsuarioAtivo()
        {
            return _contexto.Usuarios.Where(x => x.UsuarioAtivo).Any();
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            var usuario = textBoxUser.Text.ToString();
            var senha   = mTextBoxSenha.Text.ToString();
            var retorno = _contexto.Usuarios.Where(u => u.Nome == usuario && u.Senha == senha && u.UsuarioAtivo).FirstOrDefault();

            if (retorno != null)
            {
                if (checkBoxManterLogin.Checked)
                {
                    _contexto.Usuarios.AsQueryable().Where(
                            user => user.ManterLogin
                        ).ToList().ForEach(u =>
                            u.ManterLogin = false
                        );
                    retorno.ManterLogin = true;
                }
                else
                    retorno.ManterLogin = false;
                _contexto.SaveChanges();
                _contexto.Logar(retorno);
                MessageBox.Show("Usuário logado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao logar!");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            var usuario = _contexto.Usuarios.Where(u => u.ManterLogin == true && u.UsuarioAtivo);
            var existeUsuarioManterLogin = usuario.Any();
            
            if(existeUsuarioManterLogin)
            {
                var entidade = usuario.First();
                textBoxUser.Text   = entidade.Nome;
                mTextBoxSenha.Text = entidade.Senha;
                if(entidade.ManterLogin)
                    checkBoxManterLogin.Checked = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}