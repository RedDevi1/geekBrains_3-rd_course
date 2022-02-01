using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            BankAccount myBankAcnt = new BankAccount(34234.34, TypeOfAccount.savingsAcnt);           
            Console.WriteLine($"Номер Вашего счета: {myBankAcnt.UnivAcntNum}");
            
            while (!exit)
            {
                Console.WriteLine("Если хотите снять деньги со счета, нажмите: G, положить на счет - T, узнать баланс счета - B, выйти - Q");
                var command = Console.ReadKey();
                if (command.Key == ConsoleKey.T)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму для зачисления");
                    myBankAcnt.TakeMyMoney(Convert.ToInt64(Console.ReadLine()));
                }
                else if (command.Key == ConsoleKey.G)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите сумму для снятия со счета");
                    myBankAcnt.GiveMeMyMoney(Convert.ToInt64(Console.ReadLine()));
                }
                else if (command.Key == ConsoleKey.B)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Баланс Вашего счета: {myBankAcnt.Balance}");
                }
                else if (command.Key == ConsoleKey.Q)
                    exit = true;
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Неверная команда");
                }
            }
            
        }
    }
}
