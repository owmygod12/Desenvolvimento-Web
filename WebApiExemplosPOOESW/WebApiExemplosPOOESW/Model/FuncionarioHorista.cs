namespace WebApiExemplosPOOESW.Model
{
    public class FuncionarioHorista: Funcionario
    {
        public decimal ValorHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public override decimal CalcularSalario()
        {

            return ValorHora * HorasTrabalhadas;
        }
    }
}
