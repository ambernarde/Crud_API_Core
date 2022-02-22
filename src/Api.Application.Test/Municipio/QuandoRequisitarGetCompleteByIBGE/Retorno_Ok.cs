using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Interfaces.Services.Municipio;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Api.Application.Test.Municipio.QuandoRequisitarGetCompleteByIBGE
{
    public class Retorno_Ok
    {
        private MunicipiosController _controller;

        [Fact(DisplayName= "É Possivel Realizar o Get.")]
        public async Task E_Possivel_Invocar_a_Controller_Get()
        {
            var serviceMock = new Mock<IMunicipioService>();

            serviceMock.Setup( m => m.GetCompleteByIBGE(It.IsAny<int>())).ReturnsAsync(
                new MunicipioDtoCompleto
                {  
                   Id = Guid.NewGuid(),
                   Nome = "São Paulo"
                }                
            );
            _controller = new MunicipiosController(serviceMock.Object);
            _controller.ModelState.AddModelError("Id","Formato Inválido");

            var result = await _controller.GetCompleteByIBGE(1);
            Assert.True(result is BadRequestObjectResult);
        }
    }
}