using System;
using System.Globalization;

namespace Fundamentals {
    class Program { 
        static void Main(string[] args) {

            double value;

            ContaBancaria conta = new ContaBancaria();

            Console.Write("\n");
            Console.WriteLine("Dados da conta:\n" + conta.ToString());

            Console.Write("Entre com um valor para depósito: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposit(value);
            Console.WriteLine("Dados da conta:\n" + conta.ToString());

            Console.Write("Entre com um valor para saque: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Withdraw(value);
            Console.WriteLine("Dados da conta:\n" + conta.ToString());

        }
    }
}