using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAcnt_1 = new BankAccount(23423.34);                        
            myBankAcnt_1.ReadAccount();
            BankAccount myBankAcnt_2 = new BankAccount(TypeOfAccount.checkingAcnt);                       
            myBankAcnt_2.ReadAccount();
            BankAccount myBankAcnt_3 = new BankAccount(234234234.34, TypeOfAccount.savingsAcnt);                       
            myBankAcnt_3.ReadAccount();
        }
    }
}
