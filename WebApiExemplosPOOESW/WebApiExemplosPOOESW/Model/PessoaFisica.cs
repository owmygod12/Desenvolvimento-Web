namespace WebApiExemplosPOOESW.Model
{
    public class PessoaFisica: Pessoa
    {
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

        public override string RetornarDadosPessoa()
        {
            //return base.RetornadadosPessoa()
            return $"Dados Pessoa Física\r\n" +
                   $"{base.RetornarDadosPessoa()}\r\n" +
                   $"CPF: {Cpf} \r\n" +
                   $"Data de Nascimento: {DataNascimento} \r\n" +
                   $"Sexo: {Sexo} \r\n";
        }


    }
}
