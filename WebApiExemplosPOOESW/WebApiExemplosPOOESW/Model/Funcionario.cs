namespace WebApiExemplosPOOESW.Model
{
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }


        public string RetornarDadosFuncionario()
        {
            return $"Dados do Funcionário\r\n" +
                   $"Nome: {nome} \r\n" +
                   $"CPF: {Cpf} \r\n" +
                   $"Cargo: {Cargo} \r\n";
        }
        public abstract decimal CalcularSalario();
    }
}

