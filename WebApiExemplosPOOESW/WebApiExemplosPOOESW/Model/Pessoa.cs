namespace WebApiExemplosPOOESW.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        public string RetornarDadosPessoa()
        {
            return $"Dados Pessoa - Classe pai \r\n" +
                   $"Nome: {Nome} \r\n" +
                   $"Endereço: {Endereco} \r\n" +
                   $"Telefone: {Telefone} \r\n" +
                   $"Email: {Email} \r\n";
        }
    }
}
