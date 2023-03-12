using GestaProdutos.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Aplication.Interfaces
{
    public class ProdutoApp : IProdutoApp
    {

        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoApp(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public void Alterar(Produto produto)
        {
            _produtoRepositorio.Alterar(produto);
        }

        public void Excluir(Produto produto)
        {
            _produtoRepositorio.Excluir(produto);
        }

        public void Incluir(Produto produto)
        {
            _produtoRepositorio.Incluir(produto);   
        }

        public Task<Produto> ObterProID(int id)
        {
           return _produtoRepositorio.ObterProID(id);
        }

        public Task<IEnumerable<Produto>> ObterTodos()
        {
            return _produtoRepositorio.ObterTodos();
        }
    }
}
