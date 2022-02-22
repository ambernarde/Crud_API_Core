using Api.Application.Controller;
using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services.User;
using Domain.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Api.Application.Test.QuandoRequisitarUpdate
{
   
    public class Retorno_Updated
    {
         private UsersController _controller;
         [Fact(DisplayName="É possivel Realizar o Update.")]
         public async Task E_Possivel_Invocar_a_Controller_Update()
         {
             var serviceMock = new Mock<IUserService>();
             var nome = Faker.Name.FullName();
             var email = Faker.Internet.Email();

             serviceMock.Setup(m => m.Put(It.IsAny<UserDtoUpdate>())).ReturnsAsync(
                 new UserDtoUpdateResult
                 {
                     Id = Guid.NewGuid(),
                     Name= nome,
                     Email = email,
                     UpdateAt = DateTime.UtcNow
                 }
             );
             _controller = new UsersController(serviceMock.Object);

             var UserDtoUpdate = new UserDtoUpdate
             {
                Id = Guid.NewGuid(),
                Name = nome,
                Email = email
             };

             var result = await _controller.Put(UserDtoUpdate);
             Assert.True(result is OkObjectResult);

            UserDtoUpdateResult resultValue = ((OkObjectResult)result).Value as UserDtoUpdateResult;
            Assert.NotNull(resultValue);
            Assert.Equal(UserDtoUpdate.Name, resultValue.Name);
            Assert.Equal(UserDtoUpdate.Email ,resultValue.Email);


         }


         
    }
}