using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class BankAccount
        {
            private string Owner;
            private double Balance;

            public BankAccount(string accOwner, double accBalance)
            {
                Owner = accOwner;
                Balance = accBalance;
            }
            public void Deposit(double sum)
            {
                if (sum > 0)
                {
                    Balance += sum;
                    Console.WriteLine($"Пользователь {Owner}, баланс: {Balance}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Сумма увеличения баланса не может быть меньше 0.");
                    return;
                }
            }
            public void Withdraw(double sum)
            {
                if (sum > 0)
                {
                    Balance -= sum;
                    Console.WriteLine($"Пользователь {Owner}, баланс: {Balance}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Сумма уменьшения баланса не может быть меньше 0.");
                    return;
                }
            }
            public string bankAccOwner
            {
                get { return Owner; }
                set { Owner = value; }
            }
            public double bankAccBalance
            {
                get { return Balance; }
                set { Balance = value; }
            }
        }
        static void Main(string[] args)
        {
            BankAccount newBankAcc = new BankAccount("", 0);

            Console.Write("Введите имя: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) newBankAcc.bankAccOwner = input;
            else
            {
                Console.WriteLine("Ошибка: Строка пуста или состоит только из пробелов");
                return;
            }

            Console.Write("Введите баланс: ");
            if (double.TryParse(Console.ReadLine(), out double userDeposit) && userDeposit >= 0) newBankAcc.bankAccBalance = userDeposit;
            else
            {
                Console.WriteLine("Баланс должен быть больше или равен 0.");
                return;
            }            
            Console.WriteLine("Введите сумму увеличения баланса.");
            if (!double.TryParse(Console.ReadLine(), out double sum) || sum <= 0)
            {
                Console.WriteLine("Сумма должна быть больше нуля.");
                return;
            }

            newBankAcc.Deposit(sum);
            Console.WriteLine("Введите сумму уменьшения баланса.");
            if (!double.TryParse(Console.ReadLine(), out sum) || sum <= 0)
            {
                Console.WriteLine("Сумма должна быть больше нуля.");
                return;
            }
            if (sum <= newBankAcc.bankAccBalance)
            {
                newBankAcc.Withdraw(sum);
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
        }
    }
}

