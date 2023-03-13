using GestaoProduto.Infra.Data.Repositorio;
using GestaoProdutos.Aplication.Interfaces;
using GestaProdutos.Domain.Interfaces.Servicos;
using GestaProdutos.Domain.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoProdutos.Infra.IOC
{
    public class InjetorDependencia
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação          
            svcCollection.AddScoped<IProdutoFornecedorApp, ProdutoFornecedorApp>();

            //Domínio            
            svcCollection.AddScoped<IProdutoFornecedorServico, ProdutoFornecedorServico>();

            //Repositorio          
            svcCollection.AddScoped<IProdutoFornecedorRepositorio, ProdutoFonecedorRepositorio>();

        }
    }
}
