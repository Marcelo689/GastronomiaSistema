using BancoDeDados.Contexto;
using BancoDeDados.Models;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Controller
{
    public class OperacoesBanco
    {
        public abstract class TEntity
        {
            public int Id { get; set; }
        }
        private BDContexto _contexto;

        public OperacoesBanco()
        {
            _contexto = new BDContexto().getInstancia();
        }
        public List<T> RetornarLista<T>(int? [] ids = null) where T : TEntity
        {
            var lista = new List<T>();
            if(ids == null)
                lista = _contexto.Set<T>().ToList();
            else
                lista = _contexto.Set<T>().Where(e => ids.Contains( e.Id)).ToList();
            return lista;
        }
        public bool Deletar<T>(params T[] entity) where T : TEntity
        {
            _contexto.Set<T>().RemoveRange(entity);
            var mudancas = _contexto.SaveChanges();
            if (mudancas > 0)
                return true;
            return false;
        }
        public bool Deletar<T>(params int[] entityIds) where T : TEntity
        {
            var listaParaDeletar = _contexto.Set<T>().Where(e => entityIds.Contains(e.Id)).ToList();
            _contexto.Set<T>().RemoveRange(listaParaDeletar);
            var mudancas = _contexto.SaveChanges();
            if (mudancas > 0)
                return true;
            return false;
        }
        public T[] Atualizar<T>(params T[] entidades) where T : TEntity
        {
            _contexto.Set<T>().UpdateRange(entidades);
            var quantidadeMudancas = _contexto.SaveChanges();
            return entidades;
        }
        public bool Cadastrar<T>(params T[] entidades) where T : TEntity
        {
            _contexto.Set<T>().AddRange(entidades);
            var quantidadeMudancas = _contexto.SaveChanges();
            if (quantidadeMudancas > 0)
                return true;
            else
                return false;
        }
    }
}
