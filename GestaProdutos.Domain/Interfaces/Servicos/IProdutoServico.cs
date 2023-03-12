using GestaProdutos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaProdutos.Domain.Interfaces.Servicos
{
    public interface IProdutoServico
    {
        void Incluir(Produto produto);
        void Alterar(Produto produto);
        void Excluir(Produto produto);
        Task<Produto> ObterProID(int id);
        Task<IEnumerable<Produto>> ObterTodos();

    }
}
