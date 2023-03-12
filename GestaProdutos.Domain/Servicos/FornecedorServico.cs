using GestaoProdutos.Aplication.Interfaces;
using GestaProdutos.Domain.Entidades;
using GestaProdutos.Domain.Interfaces.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaProdutos.Domain.Servicos
{
    public class FornecedorServico : IFornecedorServico
    {
        //private readonly IFornecedorRepositorio           


        public void Alterar(Fornecedor produto) { 
        
        }
        

        public void Excluir(Fornecedor produto)
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(Fornecedor produto)
        {
            throw new System.NotImplementedException();
        }

        public Task<Fornecedor> ObterProID(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Fornecedor>> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
