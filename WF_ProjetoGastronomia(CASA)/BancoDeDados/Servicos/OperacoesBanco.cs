using BancoDeDados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BancoDeDados.Controller
{
    public class OperacoesBanco
    {
        public abstract class TEntity
        {
            public virtual int Id { get; set; }
        }
        private BDContexto _contexto;
        public override string ToString()
        {
            return this.GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
        public OperacoesBanco()
        {
            _contexto = new BDContexto().getInstancia();
        }
        public List<T> RetornarLista<T>(int? id = null) where T : TEntity
        {
            var lista = new List<T>();
            if(id == null)
                lista = _contexto.Set<T>().ToList();
            else
                lista = _contexto.Set<T>().Where(e => id == e.Id).ToList();
            return lista;
        }

        public List<R> RetornaListaComAlgumasColunas<T,R>(Func<T,R> filtro) where T : TEntity
        {
            var listaFiltrada = _contexto.Set<T>().ToList().Select(
                filtro
                //e => new Produto()
                //{
                //     Nome = e.Nome,
                //     PrecoPorQuantidade =  e.PrecoPorQuantidade
                //}
            ).ToList();
            return listaFiltrada;
        }
        public List<T> RetornarLista<T>(params int [] ids) where T : TEntity
        {
            var lista = new List<T>();
            lista = _contexto.Set<T>().Where(e => ids.Contains(e.Id)).ToList();
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
        public bool Atualizar<T>(params T[] entidades) where T : TEntity
        {
            _contexto.Set<T>().UpdateRange(entidades);
            var quantidadeMudancas = _contexto.SaveChanges();
            return quantidadeMudancas > 0;
        }
        public bool Cadastrar<T>(params T[] entidades) where T : TEntity
        {
            int[] idsEntidades = new int[] { };
            // pega ids das entidades
            foreach (var entidade in entidades)
            {
                idsEntidades.Append(entidade.Id);
            }

            var lista = new List<T>();
            if(idsEntidades != null && idsEntidades.Length > 0)
                lista = RetornarLista<T>(idsEntidades);

            if(lista.Count() > 0)// atualiza pois já existe
                Atualizar<T>(entidades);
            else // adiciona pois não existe no banco
                _contexto.Set<T>().AddRange(entidades);

            var quantidadeMudancas = _contexto.SaveChanges();
            if (quantidadeMudancas > 0)
                return true;
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
                return false;
            }
        }
    }
}
