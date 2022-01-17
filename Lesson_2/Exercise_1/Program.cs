using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAcnt = new BankAccount();
            myBankAcnt.FillInAccount();
            Console.Clear();
            myBankAcnt.ReadAccount();
        }
    }
}
