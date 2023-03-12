using GestaoProduto.Infra.Data.Context;
using GestaoProdutos.Aplication.Interfaces;
using GestaProdutos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoProduto.Infra.Data.Repositorio
{
    public class ForncedorRepositorio : IFornecedorRepositorio
    {
        protected readonly Contexto _contexto;

        public ForncedorRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }
        public void Alterar(Fornecedor fornecedor)
        {
            _contexto.Entry(fornecedor).State = EntityState.Modified;
        }

        public void Excluir(Fornecedor fornecedor)
        {
            _contexto.Fornecedor.Remove(fornecedor);
        }
        public void Incluir(Fornecedor fornecedor)
        {
            _contexto.Add(fornecedor);
        }

        public async Task<Fornecedor> ObterProID(int id)
        {
            return await _contexto.Fornecedor.Where(x => x.CodigoFornecedor == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Fornecedor>> ObterTodos()
        {
            return await _contexto.Fornecedor.ToListAsync();
        }
    }
}
