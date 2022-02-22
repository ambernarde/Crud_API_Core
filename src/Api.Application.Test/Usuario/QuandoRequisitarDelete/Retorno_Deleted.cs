using Api.Application.Controller;
using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services.User;
using Domain.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Api.Application.Test.QuandoRequisitarDelete
{
   
    public class Retorno_Deleted
    {
         private UsersController _controller;
         [Fact(DisplayName="É possivel Realizar o Deleted.")]
         public async Task E_Possivel_Invocar_a_Controller_Delete()
         {
             var serviceMock = new Mock<IUserService>();
    
             serviceMock.Setup(m => m.Delete(It.IsAny<Guid>()))
             .ReturnsAsync(true);
             _controller = new UsersController(serviceMock.Object);

             var result = await _controller.Delete(Guid.NewGuid());
             Assert.True(result is OkObjectResult);  

             var resultValue = ((OkObjectResult)result).Value;
             Assert.NotNull(resultValue);
             Assert.True((Boolean)resultValue);

         }


         
    }
}