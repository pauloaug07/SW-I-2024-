using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDeBanco
{
    public class Conta
    {
        private string? Num_conta { get; set; }
        private double Saldo { get; set; }
        private double Limite { get; set; }

        public void consulta_saldo()
        {
            Console.WriteLine("O saldo atual é de R$: " + Saldo);
        }
        public void depositar(double deposito)
        {
            Saldo += deposito;
        }
        public void sacar(double saque) 
        {
            if (saque <= Saldo + Limite)
            {
                Saldo -= saque;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void ajusta_limite(double valor) 
        {
            Limite = valor;
        }
    }
}
