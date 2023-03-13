using GestaProdutos.Domain.Entidades;
using GestaProdutos.Domain.Interfaces.Servicos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GestaProdutos.Domain.Servicos
{
    public class ProdutoFornecedorServico : IProdutoFornecedorServico
    {
        public void Alterar(ProdutoFornecedor produto)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(ProdutoFornecedor produto)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirLogico(ProdutoFornecedor produto)
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(ProdutoFornecedor produto)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProdutoFornecedor> ObterProID(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ProdutoFornecedor>> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveOkAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
