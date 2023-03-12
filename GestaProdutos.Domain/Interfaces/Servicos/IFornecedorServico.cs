
using GestaProdutos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaProdutos.Domain.Interfaces.Servicos
{
    public interface IFornecedorServico
    {
        void Incluir(Fornecedor produto);
        void Alterar(Fornecedor produto);
        void Excluir(Fornecedor produto);
        Task<Fornecedor> ObterProID(int id);
        Task<IEnumerable<Fornecedor>> ObterTodos();

    }
}
