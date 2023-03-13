
using GestaoProduto.Infra.Data.Context;
using GestaoProdutos.Aplication.Interfaces;
using GestaProdutos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoProduto.Infra.Data.Repositorio
{
    public class ProdutoFonecedorRepositorio : IProdutoFornecedorRepositorio
    {

        protected readonly Contexto _contexto;

        public ProdutoFonecedorRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Alterar(ProdutoFornecedor produto)
        {         
            _contexto.Entry(produto).State = EntityState.Modified;
        }

        public void ExcluirLogico(ProdutoFornecedor produto)
        {
            produto.Situacao = "Inativo";
            _contexto.Entry(produto).State = EntityState.Modified;
        }

        public void Excluir(ProdutoFornecedor produto)
        {            
            _contexto.Remove(produto);
        }

        public void Incluir(ProdutoFornecedor produto)
        {          
            _contexto.Add(produto);
        }

        public void AddAsync(ProdutoFornecedor produto)
        {
            _contexto.AddAsync(produto);
        }

        public async Task<ProdutoFornecedor> ObterProID(int id)
        {
            return await _contexto.ProdutoFornecedor.Where(x => x.CodigoProduto == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProdutoFornecedor>> ObterTodos(ProdutoFornecedor produto)
        {
            var query = _contexto.ProdutoFornecedor.AsQueryable();

            if (produto.CodigoProduto > 0)
                query = query.Where(p => p.CodigoProduto == produto.CodigoProduto);

            if (!string.IsNullOrWhiteSpace(produto.DescricaoProduto))
                query = query.Where(p => p.DescricaoProduto.Contains(produto.DescricaoProduto));

            if (!string.IsNullOrWhiteSpace(produto.Situacao))
                query = query.Where(p => p.Situacao == produto.Situacao);

            if (produto.DataFabricacao != DateTime.MinValue)
                query = query.Where(p => p.DataFabricacao == produto.DataFabricacao);

            if (produto.DataValidade != DateTime.MinValue)
                query = query.Where(p => p.DataValidade == produto.DataValidade);

            if (produto.CodigoFornecedor.HasValue)
                query = query.Where(p => p.CodigoFornecedor == produto.CodigoFornecedor);

            if (!string.IsNullOrWhiteSpace(produto.DescricaoFornecedor))
                query = query.Where(p => p.DescricaoFornecedor.Contains(produto.DescricaoFornecedor));

            if (!string.IsNullOrWhiteSpace(produto.Cnpj))
                query = query.Where(p => p.Cnpj == produto.Cnpj);

            return await query.ToListAsync();
           
        }

        public async Task<bool> SaveOkAsync()
        {
            return await _contexto.SaveChangesAsync() > 0;
        }
    }
}
