namespace WebApiExemplosPOOESW.Model
{
    public class ExemploAutoPropriedadeContaCorrente
    {
        // melhor forma de declarar propriedades, sem precisar
        // criar variáveis privadas para cada propriedade somente digitar prop  
        public string Titular { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; private set; } = 1000;

        public bool Sacar(double valor)
        {
            if (valor < Saldo)
            {
                Saldo = Saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void AlterarNomePessoa(string novoNome)
        {
            Titular = novoNome;
        }

        public double ConsultarSaldo()
        {
            return Saldo;
        }


    }
}
