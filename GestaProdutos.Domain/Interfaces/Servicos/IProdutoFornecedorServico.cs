
using GestaProdutos.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaProdutos.Domain.Interfaces.Servicos
{
    public interface IProdutoFornecedorServico
    {
        void Incluir(ProdutoFornecedor produto);
        void Alterar(ProdutoFornecedor produto);
        void Excluir(ProdutoFornecedor produto);
        void ExcluirLogico(ProdutoFornecedor produto);
        Task<ProdutoFornecedor> ObterProID(int id);
        Task<IEnumerable<ProdutoFornecedor>> ObterTodos();
        Task<bool> SaveOkAsync();

    }
}
