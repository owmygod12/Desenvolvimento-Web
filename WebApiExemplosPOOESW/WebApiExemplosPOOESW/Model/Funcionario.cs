namespace WebApiExemplosPOOESW.Model
{
    public class Funcionario
    {
        public string nome;
        public string sexo;
        public int idade;
        public double salario;

        public double CalcularDecimoTerceiro(int mesesTrabalhados)
        {
            double decimoTerceiro;
            decimoTerceiro = salario * mesesTrabalhados /12 ;
            return decimoTerceiro;
        }

        public double calcularFerias()
        {
            double ferias = salario + salario / 3;
            return ferias;
        }

        internal double CalcularDecimoTerceiro(object mesesTrabalhados)
        {
            throw new NotImplementedException();
        }
    }
}
