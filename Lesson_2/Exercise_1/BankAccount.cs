using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    enum TypeOfAccount { checkingAcnt, savingsAcnt, investmentAcnt };           // все типы банковских счетов
    class BankAccount : IEnumerable
    {       
        //private long accountNumber;                                              // номер счета
        private double balance;                                                 // баланс счета
        private TypeOfAccount typeOfAcnt;                                       // тип банковского счета
        private static long unicAcntNum;                                        // уникальный номер счета
        private static List<BankAccount> bankAccounts;                          // список банковских счетов 
        public double Balance
        {
            get => this.balance; 
            //set => this.balance = value;
        }
        public TypeOfAccount TypeOfAccount
        {
            get => this.typeOfAcnt; 
            set => this.typeOfAcnt = value;
        }
        public long UnivAcntNum => unicAcntNum;

        //public BankAccount(double balance)
        //{
        //    this.balance = balance;
        //    GenNewAcntNum();
        //}

        //public BankAccount(TypeOfAccount typeOfAcnt)
        //{
        //    this.typeOfAcnt = typeOfAcnt;
        //    GenNewAcntNum();
        //}

        public BankAccount(double balance, TypeOfAccount typeOfAcnt)
        {
            this.balance = balance;
            this.typeOfAcnt = typeOfAcnt;
            GenNewAcntNum();
        }
        public IEnumerator GetEnumerator() => bankAccounts.GetEnumerator();

        public static long GenNewAcntNum()                                      // генерирование нового уникального номера счета
        {
            return ++unicAcntNum;
        }
        public void GiveMeMyMoney(double Sum)                                             // заполнение данных счета
        {
            if (Sum > balance)
                Console.WriteLine("Недостаточно средств на счету для данной операции");
            else
                balance -= Sum;
        }
        public void TakeMyMoney(double Sum)
        {
            balance += Sum;
        }
        public void Order (BankAccount source, BankAccount receiver, double sum)
        {
            if (source.balance < sum)
                Console.WriteLine("Недостаточно средств на счету для перевода");
            else
            {
                source.balance -= sum;
                receiver.balance += sum;
            }
        }
        /*public void ReadAccount()                                               // чтение данных счета
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
