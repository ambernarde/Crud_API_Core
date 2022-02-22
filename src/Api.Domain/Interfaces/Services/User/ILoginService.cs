using Api.Domain.Entities;
using Domain.Dtos;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}