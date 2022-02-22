using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage ="Nome é compe obrigatório")]
        [StringLength(60,ErrorMessage ="Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="E-mail é campo obrigatório")]
        [EmailAddress(ErrorMessage ="E-mail me formato inválido")]
        [StringLength(100,ErrorMessage ="E-mail deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }


    }
}