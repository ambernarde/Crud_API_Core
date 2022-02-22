using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Api.Integration.Test.Uf
{
    public class QuandoRequisitarUf : BaseIntegration
    {
        [Fact]
        public async Task E_Possivel_Realizar_Crud_Usuario()
        {
            await AdicionarToken();

        }
        
    }
}