using BancoDeDados.Contexto;
using BancoDeDados.Controller;
using BancoDeDados.Controller.Model;
using BancoDeDados.Controller.Telas;
using BancoDeDados.Servicos;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class Login : FormBase
    {
        private PictureBox pictureBoxLogoEmpresa;
        private Label labelEmpresaNome;

        public Login()
        {
            InitializeComponent();
            _contexto = new BDContexto().getInstancia();
            _banco = new OperacoesBanco();
            _servico = new Servico();
        }

        public Login(PictureBox pictureBoxLogoEmpresa, Label labelEmpresaNome)
        {
            this.pictureBoxLogoEmpresa = pictureBoxLogoEmpresa;
            this.labelEmpresaNome = labelEmpresaNome; 
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
            if (comboBoxEmpresas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma empresa, caso não exista cadastre uma!","Cadastre uma empresa!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var empresa = comboBoxFunc.RetornaItemComboSelecionado<Empresa>(comboBoxEmpresas);
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

                retorno.Empresa = empresa;
                retorno.EmpresaId = empresa.Id;
                _contexto.SaveChanges();
                _contexto.Logar(retorno); 
                MessageBox.Show("Usuário logado com sucesso!","Login efetuado!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                labelEmpresaNome.Text = empresa.NomeEmpresa;
                RetornaImagemParaPictureBox(empresa.Logo, pictureBoxLogoEmpresa);

                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao logar!","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetornaImagemParaPictureBox(byte[] image, PictureBox pictureBox)
        {
            int ArraySize = image.GetUpperBound(0);

            MemoryStream ms = new MemoryStream(image, 0, ArraySize);
            pictureBox.Image = Image.FromStream(ms);
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

            comboBoxFunc.PreencheComboBox<Empresa>(comboBoxEmpresas, "NomeEmpresa");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarEmpresas());
            comboBoxFunc.PreencheComboBox<Empresa>(comboBoxEmpresas, "NomeEmpresa");
        }
    }
}
