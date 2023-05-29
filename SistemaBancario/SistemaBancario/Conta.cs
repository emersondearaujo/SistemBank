using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public String NomeConta { get; set; }
        public Titular Titular { get; set; }
        public Decimal Saldo { get; set; }
        public Decimal VerSaldo()
        {
            return Saldo;
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                Console.WriteLine("Saque não pode ser realizado, saldo insuficiente");
        }
    }
}
