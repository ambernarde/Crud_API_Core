using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage ="Id é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é campo obrigatório")]
        [StringLength(60,ErrorMessage = "Nome deve ter no máximo{1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="E-mail é campo obrigatório")]
        [EmailAddress(ErrorMessage ="e-mail em formato inválido")]
        public string Email { get; set; }

    }
}
