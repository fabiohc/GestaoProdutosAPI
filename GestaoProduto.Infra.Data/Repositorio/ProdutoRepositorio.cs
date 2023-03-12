
using GestaoProduto.Infra.Data.Context;
using GestaoProdutos.Aplication.Interfaces;
using GestaProdutos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProduto.Infra.Data.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {

        protected readonly Contexto _contexto;

        public ProdutoRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Alterar(Produto produto) 
        {
            _contexto.Entry(produto).State = EntityState.Modified;            
        }

        public void Excluir(Produto produto)
        {
            _contexto.Remove(produto);
        }

        public void Incluir(Produto produto)
        {
           _contexto.Add(produto);
        }

        public async Task<Produto> ObterProID(int id)
        {
            return await _contexto.Produto.Where(x => x.CodigoProduto == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _contexto.Produto.ToListAsync();
        }
    }
}
