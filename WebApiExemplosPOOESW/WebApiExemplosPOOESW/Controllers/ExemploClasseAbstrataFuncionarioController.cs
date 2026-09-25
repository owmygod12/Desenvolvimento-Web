using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class ExemploClasseAbstrataFuncionarioController : Controller
    {
        [HttpGet("FuncionarioCLT")]
        public string RetornarDadosFuncionarioCLT(string nomeFuncionario,
                                           string cpfFuncionario,
                                           string cargoFuncionario,
                                           decimal salarioFuncionario)
        {
            FuncionarioClt funcionario = new FuncionarioClt();
            funcionario.nome = nomeFuncionario;
            funcionario.Cpf = cpfFuncionario;
            funcionario.Cargo = cargoFuncionario;
            funcionario.SalarioMensal = salarioFuncionario;
            funcionario.CalcularSalario();
            return funcionario.RetornarDadosFuncionario();
        }

        [HttpGet("FuncionarioHorista")]
        public string RetornarDadosFuncionarioHorista(string nomeFuncionario,
                                           string cpfFuncionario,
                                           string cargoFuncionario,
                                           decimal salarioFuncionario)
        {
            FuncionarioHorista funcionario = new FuncionarioHorista();
            funcionario.nome = nomeFuncionario;
            funcionario.Cpf = cpfFuncionario;
            funcionario.Cargo = cargoFuncionario;
            funcionario.ValorHora = salarioFuncionario;
            funcionario.CalcularSalario();
            return funcionario.RetornarDadosFuncionario();
        }

    }
}
