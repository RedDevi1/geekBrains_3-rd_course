using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {           
            var exit = false;
            BankAccount myBankAcnt = new BankAccount(34234.34, TypeOfAccount.savingsAcnt);
            BankAccount myBankAcnt1 = new BankAccount(3234.34, TypeOfAccount.savingsAcnt);
            BankAccount myBankAcnt2 = new BankAccount(122234.34, TypeOfAccount.savingsAcnt);
            var listOfBankAcnt = new List<BankAccount>() { myBankAcnt, myBankAcnt1, myBankAcnt2 };
            Console.WriteLine($"Номер Вашего текущего счета: {myBankAcnt.AcntNum}");
            
            while (!exit)
            {
                Console.WriteLine("Если хотите снять деньги со счета, нажмите: G, положить на счет - T, перевести деньги с одного счета на другой - O, " +
                    "перевести деньги с текущего счета на другой - P, перевести деньги с дургого счета на текущий - A, узнать баланс счета - B, выйти - Q");
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
                else if (command.Key == ConsoleKey.O)
                {
                    BankAccount source = null;
                    BankAccount receiver = null;
                    double sum = 0;
                    Console.WriteLine();
                    OrderFromOneBankAcntToAnother(listOfBankAcnt, ref source, ref receiver, ref sum);
                    myBankAcnt.Order(source, receiver, sum);
                }
                else if (command.Key == ConsoleKey.P)
                {
                    BankAccount source = myBankAcnt;
                    BankAccount receiver = null;
                    double sum = 0;
                    Console.WriteLine();
                    OrderFromCurrentBankAcntToAnother(listOfBankAcnt, ref receiver, ref sum);
                    myBankAcnt.Order(source, receiver, sum);
                }
                else if (command.Key == ConsoleKey.A)
                {
                    BankAccount source = null;
                    BankAccount receiver = myBankAcnt;
                    double sum = 0;
                    Console.WriteLine();
                    OrderFromAnotherBankAcntToCurrent(listOfBankAcnt, ref source, ref sum);
                    myBankAcnt.Order(source, receiver, sum);
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
        public static void OrderFromOneBankAcntToAnother (List<BankAccount> listOfBankAcnt, ref BankAccount source, ref BankAccount receiver, ref double sum)
        {
            Console.WriteLine("Введите номер счета из списка с которого хотите сделать перевод:");
            foreach (var bankAccount in listOfBankAcnt)
                Console.WriteLine(bankAccount.AcntNum);
            long acntNumOfSource = Convert.ToInt64(Console.ReadLine());                                                                             //номер счета источника
            Console.WriteLine("Введите номер счета из списка на который хотите сделать перевод");
            long acntNumOfReceiver = Convert.ToInt64(Console.ReadLine());                                                                           //номер счета приемника
            Console.WriteLine("Введите сумму для перевода");
            sum = Convert.ToDouble(Console.ReadLine());
            foreach (var bankAccount in listOfBankAcnt)
            {
                if (bankAccount.AcntNum == acntNumOfSource)
                    source = bankAccount;
                else if (bankAccount.AcntNum == acntNumOfReceiver)
                    receiver = bankAccount;
            }
        }
        public static void OrderFromCurrentBankAcntToAnother(List<BankAccount> listOfBankAcnt, ref BankAccount receiver, ref double sum)
        {
            long acntNumOfSource = listOfBankAcnt[0].AcntNum;                                                                                       //номер счета источника
            Console.WriteLine("Введите номер счета из списка на который хотите сделать перевод:");
            foreach (var bankAccount in listOfBankAcnt)
                if (bankAccount.AcntNum != acntNumOfSource)
                    Console.WriteLine(bankAccount.AcntNum);
            long acntNumOfReceiver = Convert.ToInt64(Console.ReadLine());                                                                             //номер счета приемника                        
            Console.WriteLine("Введите сумму для перевода");
            sum = Convert.ToDouble(Console.ReadLine());
            foreach (var bankAccount in listOfBankAcnt)
            {
                if (bankAccount.AcntNum == acntNumOfReceiver)
                    receiver = bankAccount;          
            }
        }
        public static void OrderFromAnotherBankAcntToCurrent(List<BankAccount> listOfBankAcnt, ref BankAccount source, ref double sum)
        {
            long acntNumOfReceiver = listOfBankAcnt[0].AcntNum;                                                                                       //номер счета приемника
            Console.WriteLine("Введите номер счета из списка с которого хотите сделать перевод:");
            foreach (var bankAccount in listOfBankAcnt)
                if (bankAccount.AcntNum != acntNumOfReceiver)
                    Console.WriteLine(bankAccount.AcntNum);
            long acntNumOfSource = Convert.ToInt64(Console.ReadLine());                                                                             //номер счета источника                         
            Console.WriteLine("Введите сумму для перевода");
            sum = Convert.ToDouble(Console.ReadLine());
            foreach (var bankAccount in listOfBankAcnt)
            {
                if (bankAccount.AcntNum == acntNumOfSource)
                    source = bankAccount;
            }
        }
    }
}
