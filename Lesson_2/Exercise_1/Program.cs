using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAcnt_1 = new BankAccount(23423.34);
            myBankAcnt_1.TypeOfAccount = TypeOfAccount.checkingAcnt;
            Console.WriteLine($"Номер Вашего 1-го счета: {myBankAcnt_1.UnivAcntNum}");
            Console.WriteLine($"Баланс Вашего 1-го счета: {myBankAcnt_1.Balance}");
            Console.WriteLine($"Тип Вашего 1-го счета: {myBankAcnt_1.TypeOfAccount}");
            BankAccount myBankAcnt_2 = new BankAccount(TypeOfAccount.investmentAcnt);
            myBankAcnt_2.Balance = 1223423.34;
            Console.WriteLine($"Номер Вашего 2-го счета: {myBankAcnt_2.UnivAcntNum}");
            Console.WriteLine($"Баланс Вашего 2-го счета: {myBankAcnt_2.Balance}");
            Console.WriteLine($"Тип Вашего 2-го счета: {myBankAcnt_2.TypeOfAccount}");
            BankAccount myBankAcnt_3 = new BankAccount(234234234.34, TypeOfAccount.savingsAcnt);           
            Console.WriteLine($"Номер Вашего 3-го счета: {myBankAcnt_3.UnivAcntNum}");
            Console.WriteLine($"Баланс Вашего 3-го счета: {myBankAcnt_3.Balance}");
            Console.WriteLine($"Тип Вашего 3-го счета: {myBankAcnt_3.TypeOfAccount}");
        }
    }
}
