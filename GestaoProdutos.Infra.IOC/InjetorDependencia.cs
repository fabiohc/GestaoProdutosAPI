using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.IOC
{
    public class InjetorDependencia
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            ////Aplicação
            //svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            //svcCollection.AddScoped<IProdutoApp, ProdutoApp>();


            ////Domínio
            //svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            //svcCollection.AddScoped<IProdutoServico, ProdutoServico>();

            ////Repositorio
            //svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            //svcCollection.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

        }
    }
}
