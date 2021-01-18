using System;
using System.Globalization;

namespace Fundamentals {
    class ContaBancaria {
        public int AccountNumber { get; private set; }
        public string OwnerName { get; set; }
        public double InitialDeposit { get; set; }
        public string HaveInitialDeposit { get; set; }
        public double Total { get; private set; }


        public ContaBancaria() {
            Console.Write("Entre com o número da conta: ");
            AccountNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            OwnerName = Console.ReadLine();
            Console.Write("Haverá depósito  inicial: ");
            HaveInitialDeposit = Console.ReadLine();
            
            if(HaveInitialDeposit.ToLower().StartsWith("s") || HaveInitialDeposit.ToLower().StartsWith("y")) {
            
                Console.Write("Entre com o valor do depósito inicial: ");
                InitialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                this.construct(true, AccountNumber, OwnerName, InitialDeposit);
            } else {
                this.construct(false, AccountNumber, OwnerName);
            }   
        }

        public override string ToString() {
            return $"Conta {AccountNumber}, Titular: {OwnerName}, Saldo: ${Total.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        void construct(bool alternator, int accountNumber, string ownerName, double initialDeposit = 0) {
            if(alternator) {
                AccountNumber = accountNumber;
                OwnerName = ownerName;
                Total = InitialDeposit;
            } 
            else {
                AccountNumber = accountNumber;
                OwnerName = ownerName;
                InitialDeposit = 0;
                Total = InitialDeposit;
            }
        }
        public void Deposit(double value) {
            Total += value;
        }
        public void Withdraw(double value) {
            double aux = Total;
            Total -= value;

            if (Total < 0) {
                Total = aux;
                Console.WriteLine("Você não possui saldo o suficiente!");
            }
        }
    }
}
