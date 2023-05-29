using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta Teste";
            conta.NumeroConta = 1000;
            conta.Agencia = 001;
            conta.Saldo = 1000;

            conta.Titular = new Titular()
            {
                Cpf = "00000000000",
                Rg = "00000000000",
                Endereco = "Rua Central",
                Nome = "Emerson de Araujo"
            };
            Console.WriteLine($"O seu saldo atual é: {conta.VerSaldo()}");

            conta.Depositar(100);

            Console.WriteLine($"O seu saldo atual, após o deposito é: {conta.VerSaldo()}");

            conta.Sacar(500);

            Console.WriteLine($"O seu saldo atual, após o saque é: {conta.VerSaldo()}");

            conta.Sacar(3000);

            Console.ReadKey();
        }
    }
}
