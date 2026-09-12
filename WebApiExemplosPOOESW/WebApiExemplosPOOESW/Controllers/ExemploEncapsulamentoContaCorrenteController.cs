using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class ExemploEncapsulamentoContaCorrenteController : Controller
    {
        [HttpGet("ListarDadosCorrentista")]
        public string ListarDadosCorrentista(string nomeCorrentista, string numeroConta,
            double saldoCorrentista)
        {
            ContaCorrente contacorrente = new ContaCorrente();
            contacorrente.Titular = nomeCorrentista;
            contacorrente.Numero = (numeroConta);
            // contacorrente.Saldo = saldoCorrentista;

            return $"Dados do correntista \r\n" +
                     $"Titular: {contacorrente.Titular} \r\n" +
                     $"Número da conta: {contacorrente.Numero} \r\n" +
                     $"Saldo: {contacorrente.Saldo}";



        }

        [HttpGet("EmitirSaldoCorrentista")]
        public string EmitirSaldoCorrentista(string nomeCorrentista, string numeroConta,
            double saldoCorrentista)
        {
            ContaCorrente contacorrente = new ContaCorrente();
            contacorrente.Titular = nomeCorrentista;
            contacorrente.Numero = (numeroConta);
            // contacorrente.Saldo = saldoCorrentista;

            return $"Dados do correntista \r\n" +
                     $"Titular: {contacorrente.Titular} \r\n" +
                     $"Número da conta: {contacorrente.Numero} \r\n" +
                     $"Saldo: {contacorrente.Saldo}";



        }

        [HttpPost("SacarValorCorrentista")]
        public string SacarValorCorrentista(string nomeCorrentista, string numeroConta,
            double ValorSaque)
        {
            ContaCorrente contacorrente = new ContaCorrente();
            contacorrente.Titular = nomeCorrentista;
            contacorrente.Numero = (numeroConta);
            if (contacorrente.Sacar(ValorSaque))
            {

                return $"Dados do correntista \r\n" +
                    $"Saque Autorizado\r\n" +
                     $"Titular: {contacorrente.Titular} \r\n" +
                     $"Número da conta: {contacorrente.Numero} \r\n" +
                     $"Valor Sacado: R${ValorSaque} \r\n" +
                     $"Saldo da conta : R${contacorrente.Saldo}";

            }
            else
            {
                return $"Dados do correntista \r\n" +
                    $"Saque Não autorizado - valor insuficiente\r\n" +
                     $"Titular: {contacorrente.Titular} \r\n" +
                     $"Número da conta: {contacorrente.Numero} \r\n" +
                     $"Valor Sacado: R${ValorSaque} \r\n" +
                     $"Saldo da conta : R${contacorrente.Saldo}";

            }


        }
        [HttpPost("DepositarValorCorrentista")]
        public string DepositarValorCorrentista(string nomeCorrentista, string numeroConta,
            double ValorDeposito)
        {
            ContaCorrente contacorrente = new ContaCorrente();
            contacorrente.Titular = nomeCorrentista;
            contacorrente.Numero = (numeroConta);
            contacorrente.Depositar(ValorDeposito);

            return $"Dados do correntista \r\n" +
                $"Depóstio aturoizado \r\n" +
                 $"Titular: {contacorrente.Titular} \r\n" +
                 $"Número da conta: {contacorrente.Numero} \r\n" +
                 $"Valor Depositado: R${ValorDeposito} \r\n" +
                 $"Saldo da conta : R${contacorrente.Saldo}";




        }
    }
}

