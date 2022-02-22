using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Data.Implementations;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDepenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            
            serviceCollection.AddScoped<IUfRepository,UfImplementation>();
            serviceCollection.AddScoped<IMunicipioRepository, MunicipioImplementation>();
            serviceCollection.AddScoped<ICepRepository,CepImplementation>();

            //if (Environment.GetEnvironmentVariable("DATABASE").ToLower() == "SQLSERVER".ToLower())
            //{

            //    //serviceCollection.AddDbContext<MyContext>(
            //    //    options => options.UseSqlServer("Server=.\\SQLEXPRESS2019;Initial Catalog=dbAPI;MultipleActiveResultSets=true;User ID=sa;Password=mudar@123")

            //    //    );

            //    serviceCollection.AddDbContext<MyContext>(
            //        options => options.UseSqlServer(Environment.GetEnvironmentVariable("DB_CONNECTION"))

            //        );

            //}
            //else
            //{
            //    //serviceCollection.AddDbContext<MyContext>(
            //    //    options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=mudar@123")

            //    //    );
            //    serviceCollection.AddDbContext<MyContext>(
            //       options => options.UseMySql(Environment.GetEnvironmentVariable("DB_CONNECTION"))

            //       );

            //}

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=mudar@123")

                );

        }
    }
}