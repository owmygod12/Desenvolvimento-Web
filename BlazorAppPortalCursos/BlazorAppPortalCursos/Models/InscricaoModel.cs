using System.ComponentModel.DataAnnotations;

namespace BlazorAppPortalCursos.Models
{
    public class InscricaoModel
    {
        [Required(ErrorMessage="O nome é obrigatório")]
        [StringLength(80, ErrorMessage ="Máximo de 80 caracteres.")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage ="Informe um e-mail válido.")]
        public string Email {  get; set; } = string.Empty;
        [Required(ErrorMessage = "Selecione um curso")]
        public string Curso {  get; set; } = string.Empty;
        [StringLength(300, ErrorMessage = "Máximo de 300 caracteres.")]
        public string? Comentario { get; set; }
    }
}
