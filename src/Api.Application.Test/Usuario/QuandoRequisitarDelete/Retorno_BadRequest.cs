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
   
    public class Retorno_BadRequest
    {
         private UsersController _controller;
         [Fact(DisplayName="É possivel Realizar o Deleted.")]
         public async Task E_Possivel_Invocar_a_Controller_Delete()
         {
             var serviceMock = new Mock<IUserService>();
   
             serviceMock.Setup(m => m.Delete(It.IsAny<Guid>())).ReturnsAsync(false);

             _controller = new UsersController(serviceMock.Object);
             _controller.ModelState.AddModelError("Id","Formato Inválido");

            
             var result = await _controller.Delete(default(Guid));
             var resultT = (result is BadRequestObjectResult);
             Assert.True(result is BadRequestObjectResult);
             Assert.False(_controller.ModelState.IsValid);
 

          

         }


         
    }
}