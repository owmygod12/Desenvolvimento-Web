using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet("ListarDadosFuncionario")]
        public string ListarDadosFuncionario(string nomeFuncionario,
            string sexoFuncionario,
            int idadeFuncionario, double salarioFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.salario = salarioFuncionario;

            return $"##########DADOS FUNCIONÁRIO##########\r\n" +
                   $"Nome Funcionario: {funcionario.nome}\r\n" +
                   $"Sexo Funcionario : {funcionario.sexo}\r\n" +
                   $"Idade Funcionario : {funcionario.idade}\r\n" +
                   $"Salário Funcionario: {funcionario.salario}";

        }

        [HttpPost("CalcularDecimoTerceiro")]
        public string CalcularDecimoTerceiro(string nomeFuncionario,
            string sexoFuncionario,
            int idadeFuncionario, double salarioFuncionario, int mesesTrabalhados)
        {
            Funcionario funcionario = new Funcionario();
            double decimoTerceiro;
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.salario = salarioFuncionario;

            decimoTerceiro = funcionario.CalcularDecimoTerceiro(mesesTrabalhados);
            return $"##########DÉCIMO TERCEIRO DO FUNCIONÁRIO##########\r\n" +
                  $"Nome Funcionario: {funcionario.nome}\r\n" +
                  $"Sexo Funcionario : {funcionario.sexo}\r\n" +
                  $"Idade Funcionario : {funcionario.idade}\r\n" +
                  $"Salário Funcionario | R${funcionario.salario}\r\n" +
                  $"Décimo Terceiro     |   R${Math.Round(decimoTerceiro, 2)} ";



        }
        [HttpGet("CalacularFeriasFuncionario")]
        public string CalcularFeriasFuncionario(string nomeFuncionario,
            string sexoFuncionario,
            int idadeFuncionario, double salarioFuncionario)
        {
            
            Funcionario funcionario = new Funcionario();
            double ferias;
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.salario = salarioFuncionario;
            //chamei metodo calcular ferias
            ferias = funcionario.calcularFerias();

            return $"##########FÉRIAS FUNCIONÁRIO##########\r\n" +
                   $"Nome Funcionario: {funcionario.nome}\r\n" +
                   $"Sexo Funcionario : {funcionario.sexo}\r\n" +
                   $"Idade Funcionario : {funcionario.idade}\r\n" +
                   $"Salário Funcionario: R${funcionario.salario}\r\n" +
                   $"Salário de férias    : R${Math.Round(ferias, 2)}";
        }


    }
}
