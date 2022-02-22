using Api.Domain.Interfaces.Services.Cep;
using Api.Domain.Interfaces.Services.Municipio;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Interfaces.Services.User.Uf;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService , UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();

            serviceCollection.AddTransient<IUfService, UfService>();
            serviceCollection.AddTransient<IMunicipioService, MunicipioService>();
            serviceCollection.AddTransient<ICepService, CepService>();

        }
        
    }
}