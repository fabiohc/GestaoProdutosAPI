using GestaProdutos.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Aplication.Interfaces
{
    public class ProdutoFornecedorApp : IProdutoFornecedorApp
    {

        private readonly IProdutoFornecedorRepositorio _produtoFornecedor;

        public ProdutoFornecedorApp(IProdutoFornecedorRepositorio produtoFornecedor)
        {
            _produtoFornecedor = produtoFornecedor;
        }             

        public void Alterar(ProdutoFornecedor produto)
        {
            _produtoFornecedor.Alterar(produto);
        }

        public void Excluir(ProdutoFornecedor produto)
        {
            _produtoFornecedor.Excluir(produto);
        }

        public void ExcluirLogico(ProdutoFornecedor produto)
        {
            _produtoFornecedor.Alterar(produto);
        }

        public void Incluir(ProdutoFornecedor produto)
        {
            
            _produtoFornecedor.Incluir(produto);
        }

        public Task<ProdutoFornecedor> ObterProID(int id)
        {
            return _produtoFornecedor.ObterProID(id);
        }

        public Task<IEnumerable<ProdutoFornecedor>> ObterTodos(ProdutoFornecedor produto)
        {
            return _produtoFornecedor.ObterTodos(produto);
        }

        public Task<bool> SaveOkAsync()
        {
            return _produtoFornecedor.SaveOkAsync();
        }
    }
}
