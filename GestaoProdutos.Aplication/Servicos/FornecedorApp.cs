using GestaProdutos.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Aplication.Interfaces
{
    public class FonecedorApp : IFornecedorApp
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FonecedorApp(IFornecedorRepositorio fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }

        public void Alterar(Fornecedor fornecedor)
        {
            _fornecedorRepositorio.Alterar(fornecedor);
        }

        public void Excluir(Fornecedor fornecedor)
        {
            _fornecedorRepositorio.Incluir(fornecedor);
        }

        public void Incluir(Fornecedor fornecedor)
        {
            _fornecedorRepositorio.Incluir(fornecedor);
        }

        public Task<Fornecedor> ObterProID(int id)
        {
            return _fornecedorRepositorio.ObterProID(id);
        }

        public Task<IEnumerable<Fornecedor>> ObterTodos()
        {
            return _fornecedorRepositorio.ObterTodos();
        }
    }
}
