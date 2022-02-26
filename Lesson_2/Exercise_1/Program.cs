using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {           
            var exit = false;
            BankAccount myBankAcnt = new BankAccount(34234.34, TypeOfAccount.SavingsAcnt);
            BankAccount myBankAcnt1 = new BankAccount(3234.34, TypeOfAccount.SavingsAcnt);
            BankAccount myBankAcnt2 = new BankAccount(122234.34, TypeOfAccount.SavingsAcnt);
            BankAccount myBankAcnt3 = new BankAccount(3234.34, TypeOfAccount.SavingsAcnt);
            BankAccount myBankAcnt4 = new BankAccount(3234.34, TypeOfAccount.CheckingAcnt);
            var listOfBankAcnt = new List<BankAccount>() { myBankAcnt, myBankAcnt1, myBankAcnt2 };

            // тестирование переопределенных операторов и методов Equals и ToString
            var bankAcnt = myBankAcnt1 == myBankAcnt3;
            Console.WriteLine(bankAcnt);
            var bankAcnt1 = myBankAcnt1 == myBankAcnt4;
            Console.WriteLine(bankAcnt1);
            Console.WriteLine(myBankAcnt1.Equals(myBankAcnt3));
            Console.WriteLine(myBankAcnt1.Equals(myBankAcnt4));
            Console.WriteLine(myBankAcnt.ToString());
            Console.WriteLine($"Хэш код счета {myBankAcnt.AcntNum}: {myBankAcnt.GetHashCode()}");

            //вывод на консоль номера текущего счета для операций перевода со стороннего счета на текущий счет и с текущего счета на сторонний счет
            Console.WriteLine($"Номер Вашего текущего счета: {myBankAcnt.AcntNum}"); 
            
            while (!exit)
            {
                Console.WriteLine("Если хотите снять деньги со счета, нажмите: G, положить на счет - T, перевести деньги с одного счета на другой - O, " +
                    "перевести деньги с текущего счета на другой - P, перевести деньги с дургого счета на текущий - A, узнать баланс счета - B, выйти - Q");
                var command = Console.ReadKey();

                //анализ введенной команды
                BankAccount source;
                BankAccount receiver;
                double sum = 0;
                switch (command.Key)
                {
                    case ConsoleKey.T:
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму для зачисления");
                        myBankAcnt.TakeMyMoney(Convert.ToInt64(Console.ReadLine()));
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine();
                        Console.WriteLine("Введите сумму для снятия со счета");
                        myBankAcnt.GiveMeMyMoney(Convert.ToInt64(Console.ReadLine()));
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine();
                        Console.WriteLine($"Баланс Вашего счета: {myBankAcnt.Balance}");
                        break;
                    case ConsoleKey.O:
                        source = null;
                        receiver = null;                        
                        Console.WriteLine();
                        OrderFromOneBankAcntToAnother(listOfBankAcnt, ref source, ref receiver, ref sum);
                        myBankAcnt.Order(source, receiver, sum);
                        break;
                    case ConsoleKey.P:
                        source = myBankAcnt;
                        receiver = null;                       
                        Console.WriteLine();
                        OrderFromCurrentBankAcntToAnother(listOfBankAcnt, ref receiver, ref sum);
                        myBankAcnt.Order(source, receiver, sum);
                        break;
                    case ConsoleKey.A:
                        source = null;
                        receiver = myBankAcnt;                       
                        Console.WriteLine();
                        OrderFromAnotherBankAcntToCurrent(listOfBankAcnt, ref source, ref sum);
                        myBankAcnt.Order(source, receiver, sum);
                        break;
                    case ConsoleKey.Q:
                        exit = true;
                        break;
                }               
            }
            
        }
        /// <summary>
        /// перевод средств с одного счета на другой
        /// </summary>
        /// <param name="listOfBankAcnt">список доступных счетов</param>
        /// <param name="source">счет источника перевода</param>
        /// <param name="receiver">счет получателя перевода</param>
        /// <param name="sum"> сумма перевода</param>
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
        /// <summary>
        /// перевод средств с текущего счета на сторонний
        /// </summary>
        /// <param name="listOfBankAcnt">список доступных счетов</param>
        /// <param name="receiver">счет получателя перевода</param>
        /// <param name="sum">сумма перевода</param>
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
        /// <summary>
        /// перевод средств со стороннего счета на текущий
        /// </summary>
        /// <param name="listOfBankAcnt">список доступных счетов</param>
        /// <param name="source">счет источника перевода</param>
        /// <param name="sum">сумма перевода</param>
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
