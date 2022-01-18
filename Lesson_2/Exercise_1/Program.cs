using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAcnt_1 = new BankAccount();
            myBankAcnt_1.FillInAccount();            
            myBankAcnt_1.ReadAccount();
            BankAccount myBankAcnt_2 = new BankAccount();
            myBankAcnt_2.FillInAccount();            
            myBankAcnt_2.ReadAccount();
            BankAccount myBankAcnt_3 = new BankAccount();
            myBankAcnt_3.FillInAccount();            
            myBankAcnt_3.ReadAccount();
        }
    }
}
