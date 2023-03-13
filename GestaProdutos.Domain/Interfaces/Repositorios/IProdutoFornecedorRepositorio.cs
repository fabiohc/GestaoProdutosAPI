using GestaProdutos.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Aplication.Interfaces
{
    public interface IProdutoFornecedorRepositorio
    {
        void Incluir(ProdutoFornecedor produto);
        void Alterar(ProdutoFornecedor produto);
        void Excluir(ProdutoFornecedor produto);
        void ExcluirLogico(ProdutoFornecedor produto);
        Task<ProdutoFornecedor> ObterProID(int id);
        Task<IEnumerable<ProdutoFornecedor>> ObterTodos(ProdutoFornecedor produto);
        Task<bool> SaveOkAsync();     

    }
}
