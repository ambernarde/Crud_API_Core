using Api.CrossCutting.Mappings;
using Api.Data.Context;
using application;
using AutoMapper;
using Domain.Dtos;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Api.Integration.Test
{
    public class BaseIntegration : IDisposable
    {
        public MyContext myContext { get ; private set; }

        public HttpClient client { get; private set; }

        public IMapper mapper { get; set; }

        public string hostApi { get; set; }

        public HttpResponseMessage response { get; set; }

        //public BaseIntegration()
        //{ 
        //  hostApi = "http://localhost:5000/api/";
        //  var builder = new WebHostBuilder()
        //  .UseEnvironment("Testing")
        //  .UseStartup<Startup>();
        //  var server = new TestServer(builder);

        //  myContext = server.Host.Service.GetService(typeof(MyContext)) as myContext;
        //  myContext.Database.Migrate();

        //  mapper = new AutoMapperFixture().GetMapper();

        //  client = server.CreateClient();
        //}

        public async Task AdicionarToken()
        {
            var loginDto = new LoginDto()
            {
                Email = "mfrinfo@mail.com"
            };

            var resultLogin = await PostJsonAsync(loginDto, $"{hostApi}login", client);
            var jsonLogin = await resultLogin.Content.ReadAsStringAsync();
            var loginObject = JsonConvert.DeserializeObject<LoginResponseDto>(jsonLogin);

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                                                        // loginObject.accessToken);


        }
        public static async Task<HttpResponseMessage> PostJsonAsync(object dataClass, string url,HttpClient client)
        {
            return await client.PostAsync(url,
            new StringContent(JsonConvert.SerializeObject(dataClass),System.Text.Encoding.UTF8,"application/json"));
            
        }   

        public void Dispose()
        {
            myContext.Dispose();
            client.Dispose();
        }
    }
}

public class AutoMapperFixture : IDisposable
{
   public IMapper GetMapper()
   {
       var config = new MapperConfiguration(cfg => 
       {
          cfg.AddProfile(new ModelEntityProfile());
          cfg.AddProfile(new EntityToDtoProfile());
          cfg.AddProfile(new ModelEntityProfile());
          
       });
       return config.CreateMapper();
   }
   public void Dispose(){}
}