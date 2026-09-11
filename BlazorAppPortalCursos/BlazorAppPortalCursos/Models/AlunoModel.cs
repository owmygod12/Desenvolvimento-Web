using System.ComponentModel.DataAnnotations;

namespace BlazorAppPortalCursos.Models
{
    public class AlunoModel
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = string.Empty;

        [Range(16, 100, ErrorMessage = "Idade entre 16 e 100.")]
        public int Idade { get; set; } = 18;

        [Required(ErrorMessage = "Informe a data de nascimento.")]
        public DateTime DataNascimento { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Selecione o turno.")]
        public string Turno { get; set; } = string.Empty;

        [Range(typeof(bool), "true", "true", ErrorMessage = "É necessário aceitar os termos.")]
        public bool AceitaTermos { get; set; }
    }
}
