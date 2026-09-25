namespace WebApiExemplosPOOESW.Model
{
    public  class FuncionarioClt : Funcionario
    {
        public decimal SalarioMensal { get; set; }

        public override decimal CalcularSalario()
        {

            return SalarioMensal;
        }
    }
}
