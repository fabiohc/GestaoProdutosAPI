using GestaProdutos.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Aplication.Interfaces
{
    public interface IProdutoRepositorio
    { 
        void Incluir(Produto produto);
        void Alterar(Produto produto);
        void Excluir(Produto produto);
        Task<Produto> ObterProID(int id);
        Task<IEnumerable<Produto>> ObterTodos();

    }
}
