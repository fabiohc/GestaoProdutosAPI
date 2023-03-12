using GestaoProduto.Infra.Data.Repositorio;
using GestaoProdutos.Aplication.Interfaces;
using GestaProdutos.Domain.Servicos;
using Microsoft.Extensions.DependencyInjection;
using GestaProdutos.Domain.Interfaces.Servicos;

namespace GestaoProdutos.Infra.IOC
{
    public class InjetorDependencia
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped<IFornecedorApp, FonecedorApp>();
            svcCollection.AddScoped<IProdutoApp, ProdutoApp>();

            //Domínio
            svcCollection.AddScoped<IFornecedorServico, FornecedorServico>();
            svcCollection.AddScoped<IProdutoServico, ProdutoServico>();

            //Repositorio
            svcCollection.AddScoped<IFornecedorRepositorio, ForncedorRepositorio>();
            svcCollection.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

        }
    }
}
