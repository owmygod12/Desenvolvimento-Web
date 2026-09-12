namespace WebApiExemplosPOOESW.Model
{
    public class ContaCorrente
    {
        private string numero;
        private string titular;
        private double saldo = 1000;

        public ContaCorrente()
        {
           

        }

        public ContaCorrente(string numero, string titular )
        {
            this.numero = numero;
            this.titular = titular;
            
        }

        public string Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; private set => saldo = value; }

        public bool Sacar(double valor)
        {
            if (valor < saldo)
            {
                saldo = saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void AlterarNomePessoa(string novoNome)
        {
            titular = novoNome;
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }


    }
}