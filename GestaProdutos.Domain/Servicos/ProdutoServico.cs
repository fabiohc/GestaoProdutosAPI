using GestaProdutos.Domain.Entidades;
using GestaProdutos.Domain.Interfaces.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaProdutos.Domain.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        public void Alterar(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> ObterProID(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
