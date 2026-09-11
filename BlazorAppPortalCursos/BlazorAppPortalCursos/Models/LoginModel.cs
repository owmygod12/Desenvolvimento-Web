using System.ComponentModel.DataAnnotations;

namespace BlazorAppPortalCursos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Informe o usuário.")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a senha.")]
        [MinLength(4, ErrorMessage = "A senha deve ter ao menos 4 caracteres.")]
        public string Senha { get; set; } = string.Empty;
        public bool Lembrar { get; set; }
    }
}
