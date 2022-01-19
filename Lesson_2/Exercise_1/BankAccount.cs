using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    enum TypeOfAccount { checkingAcnt, savingsAcnt, investmentAcnt };           // все типы банковских счетов
    class BankAccount
    {       
        //private long accountNumber;                                              // номер счета
        private double balance;                                                 // баланс счета
        private TypeOfAccount typeOfAcnt;                                       // тип банковского счета
        private static long unicAcntNum;                                        // уникальный номер счета

        public double Balance
        {
            get => this.balance; 
            set => this.balance = value;
        }
        public TypeOfAccount TypeOfAccount
        {
            get => this.typeOfAcnt; 
            set => this.typeOfAcnt = value;
        }
        public long UnivAcntNum => unicAcntNum;

        public BankAccount(double balance)
        {
            this.balance = balance;
            GenNewAcntNum();
        }

        public BankAccount(TypeOfAccount typeOfAcnt)
        {
            this.typeOfAcnt = typeOfAcnt;
            GenNewAcntNum();
        }

        public BankAccount(double balance, TypeOfAccount typeOfAcnt)
        {
            this.balance = balance;
            this.typeOfAcnt = typeOfAcnt;
            GenNewAcntNum();
        }

        public static long GenNewAcntNum()                                      // генерирование нового уникального номера счета
        {
            return ++unicAcntNum;
        }
        /*public void FillInAccount()                                             // заполнение данных счета
        {
            //Console.WriteLine("Введите номер счета");
            //this.accountNumber = Convert.ToInt64(Console.ReadLine());
            GenNewAcntNum();
            Console.WriteLine("Введите баланс счета");
            this.balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите номер типа банковского счета:");
            Console.WriteLine("1. Расчетный счет");
            Console.WriteLine("2. Сберегательный счет");
            Console.WriteLine("3. Инвестиционный счет");
            var typeOfAcnt = Convert.ToInt32(Console.ReadLine());
            if (typeOfAcnt == 1)
                this.typeOfAcnt = TypeOfAccount.checkingAcnt;
            else if (typeOfAcnt == 2)
                this.typeOfAcnt = TypeOfAccount.savingsAcnt;
            else
                this.typeOfAcnt = TypeOfAccount.investmentAcnt;
        }
        public void ReadAccount()                                               // чтение данных счета
        {
            var curTypeOfAcnt = GetEnum(this.typeOfAcnt);
            Console.WriteLine($"Номер Вашего счета: {BankAccount.unicAcntNum}");
            Console.WriteLine($"Баланс Вашего счета: {this.balance}");
            Console.WriteLine($"Тип Вашего счета: {curTypeOfAcnt}");
        }*/
        public static string GetEnum(TypeOfAccount typeOfAcnt)                  // метод расширения для перечисления, переводящий перечисление в строковое значение
        {
            string curTypeOfAcnt = null;                                                  // текущий тип банковского счета
            if (typeOfAcnt == TypeOfAccount.checkingAcnt)
                curTypeOfAcnt = "Расчетный";
            else if (typeOfAcnt == TypeOfAccount.savingsAcnt)
                curTypeOfAcnt = "Сберегательный";
            else
                curTypeOfAcnt = "Инвестиционный";
            return curTypeOfAcnt;
        }
    }
}
