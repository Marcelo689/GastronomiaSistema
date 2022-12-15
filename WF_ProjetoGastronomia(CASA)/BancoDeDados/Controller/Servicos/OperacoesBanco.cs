using BancoDeDados.Contexto;
using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Controller.Telas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
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

        public List<Produto> RetornaProdutosDaReceita(int idReceita)
        {
            if(idReceita == 0)  
                return new List<Produto>();
            var idsProdutos = _contexto.ProdutosReceita.Where(x => x.ReceitaId == idReceita).Select( e => e.ProdutoId).ToList();
            var lista = _contexto.Produtos.Where(e => idsProdutos.Contains(e.Id)).ToList();
            
            foreach (var item in lista)
            {
                var quantidade = RetornaQuantidadeProdutoNaReceita(idReceita, item.Id);
                var total = quantidade * item.PrecoPorQuantidade;
                item.QuantidadeProduto = quantidade.ToString("F2", CultureInfo.InvariantCulture);
            }
            return lista;
        }

        public decimal RetornaQuantidadeProdutoNaReceita(int idReceita, int idProduto)
        {
            var quantidade = _contexto.ProdutosReceita.Where(x => x.ReceitaId == idReceita && idProduto == x.ProdutoId).Select(e => e.QuantidadeProduto).First();
            return quantidade;
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

        public List<R> RetornaListaComAlgumasColunas<T,R>(Expression<Func<T,R>> filtro) 
            where T : TEntity 
            where R : TEntity
        {
            var listaFiltrada = _contexto.Set<T>().Select(
                filtro
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
            try
            {
                var mudancas = _contexto.SaveChanges();
                if (mudancas > 0)
                    return true;
            }catch (Exception)
            {
                MessageBox.Show("Erro ao deletar, existe algo que depende do que você tentou deletar!");
            }
            return false;
        }

        public List<GastoReceitaListView> RetornaGastosDaReceita(int idReceita)
        {
            if (idReceita == 0)
                return new List<GastoReceitaListView>();
            var gastosDaReceita = _contexto.GastosReceita.Where(e => idReceita == e.ReceitaId);
            var idsGastos = gastosDaReceita.Select(e => e.Id).ToArray();
            var quantidades = gastosDaReceita.Select(e => e.QuantidadeGasto).ToList();
            var lista =  _contexto.Gastos.Where(e => idsGastos.Contains(e.Id)).ToList();
            var saidaLista = new List<GastoReceitaListView>();
            
            foreach (var item in lista.Select((value, i) => new { i, value }))
            {
                saidaLista.Add(new GastoReceitaListView
                {
                    Id = item.value.Id,
                    Nome = item.value.Nome,
                    QuantidadeGasto = quantidades[item.i]
                });
            }

            return saidaLista;
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
