namespace WebApiExemplosPOOESW.Model
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }


    public override string RetornarDadosPessoa()
        {
            return $"Dados Pessoa Jurídica\r\n" +
                   $"{base.RetornarDadosPessoa()}\r\n" +
                   $"CNPJ: {Cnpj} \r\n" +
                   $"Razão Social {RazaoSocial} \r\n" +
                   $"Nome Fantasia {NomeFantasia} \r\n";
        }
    }


}

