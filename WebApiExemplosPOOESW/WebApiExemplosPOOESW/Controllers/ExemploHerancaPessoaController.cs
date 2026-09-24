using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class ExemploHerancaPessoaController : Controller
    {
        [HttpGet("RetornaDadosPessoa")]

        public string RetonrnaDadosPessoa(string nomePessoa,
            string enderecoPessoa, string telefonePessoa,
            string emailPessoa)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nomePessoa;
            pessoa.Endereco = enderecoPessoa;
            pessoa.Telefone = telefonePessoa;
            pessoa.Email = emailPessoa;

            return pessoa.RetornarDadosPessoa();
     
        }

        [HttpGet("RetornaDadosPessoaFisica")]

        public string RetonrnaDadosPessoaFisica(string nomePessoa,
           string enderecoPessoa, string telefonePessoa,
           string emailPessoa, string cpfPessoa, DateTime dataNascimentoPessoa,
           string sexo)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = nomePessoa;
            pessoaFisica.Endereco = enderecoPessoa;
            pessoaFisica.Telefone = telefonePessoa;
            pessoaFisica.Email = emailPessoa;
            pessoaFisica.Cpf = cpfPessoa;
            pessoaFisica.DataNascimento = dataNascimentoPessoa;
            pessoaFisica.Sexo = sexo;

            return pessoaFisica.RetornarDadosPessoa();
        }

        [HttpGet("RetornaDadosPessoaJuridica")]

        public string RetonrnaDadosPessoaJuridica(string nomePessoa,
           string enderecoPessoa, string telefonePessoa,
           string emailPessoa, string cnpjPessoa, string razaoSocialPessoa,
           string nomeFantasiaPessoa)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = nomePessoa;
            pessoaJuridica.Endereco = enderecoPessoa;
            pessoaJuridica.Telefone = telefonePessoa;
            pessoaJuridica.Email = emailPessoa;
            pessoaJuridica.Cnpj = cnpjPessoa;
            pessoaJuridica.RazaoSocial = razaoSocialPessoa;
            pessoaJuridica.NomeFantasia = nomeFantasiaPessoa;

            return pessoaJuridica.RetornarDadosPessoa();
        }
    }

}
