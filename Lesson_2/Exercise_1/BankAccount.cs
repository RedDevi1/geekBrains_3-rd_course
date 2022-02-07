using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    
    public enum TypeOfAccount { CheckingAcnt, SavingsAcnt, InvestmentAcnt };           // все типы банковских счетов
    public class BankAccount
    {                                                    
        private double balance;                                                 // баланс счета
        private TypeOfAccount typeOfAcnt;                                       // тип банковского счета
        private long acntNum;                                                   // номер счета
        private static long unicAcntNum;                                        // уникальный номер счета
 
        public double Balance => this.balance;
       
        public TypeOfAccount TypeOfAccount => this.typeOfAcnt;
       
        public long UnivAcntNum => unicAcntNum;

        public long AcntNum
        {
            get => this.acntNum;
        }
        
        public BankAccount(double balance, TypeOfAccount typeOfAcnt)
        {
            this.balance = balance;
            this.typeOfAcnt = typeOfAcnt;
            GenNewAcntNum();
            acntNum = unicAcntNum;
        }
        /// <summary>
        /// генерирование нового уникального номера счета
        /// </summary>
        /// <returns>уникальный номер счета</returns>
        public static long GenNewAcntNum()
        {
            return ++unicAcntNum;
        }
        /// <summary>
        /// перевод средств со счета
        /// </summary>
        /// <param name="Sum"></param>
        public void GiveMeMyMoney(double Sum)
        {
            if (Sum > balance)
                throw new NotImplementedException($"недостаточно средств на счете: {this.acntNum}");
            else
                balance -= Sum;
        }
        /// <summary>
        /// зачисление средств на счет
        /// </summary>
        /// <param name="Sum"></param>
        public void TakeMyMoney(double Sum)
        {
            balance += Sum;
        }
        /// <summary>
        /// метод перевода средств между счетами
        /// </summary>
        /// <param name="source">счет источника перевода</param>
        /// <param name="receiver">счет получателя перевода</param>
        /// <param name="sum">сумма перевода</param>
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
        /// <summary>
        /// метод для перечисления, переводящий перечисление в строковое значение
        /// </summary>
        /// <param name="typeOfAcnt">тип банковского счета</param>
        /// <returns></returns>
        public static string GetEnum(TypeOfAccount typeOfAcnt) 
        {
            string curTypeOfAcnt = null;                                                    // текущий тип банковского счета
            switch (typeOfAcnt)
            {
                case TypeOfAccount.CheckingAcnt: curTypeOfAcnt = "Расчетный"; break;
                case TypeOfAccount.SavingsAcnt: curTypeOfAcnt = "Сберегательный"; break;
                case TypeOfAccount.InvestmentAcnt: curTypeOfAcnt = "Инвестиционный"; break;
            }
            return curTypeOfAcnt;
        }
        /// <summary>
        /// определение оператора "равно" для объектов типа BankAccount
        /// </summary>
        /// <param name="acnt_1">первый сравниваемый объект</param>
        /// <param name="acnt_2">второй сравниваемый объект</param>
        /// <returns></returns>
        public static bool operator ==(BankAccount acnt_1, BankAccount acnt_2)
        {
            if (acnt_1 is null)
                throw new ArgumentNullException($"счет {acnt_1} пуст");
            if (acnt_2 is null)
                throw new ArgumentNullException($"счет {acnt_2} пуст");
            return (acnt_1.typeOfAcnt == acnt_2.typeOfAcnt && acnt_1.balance == acnt_2.balance);
        }
        /// <summary>
        /// определение оператора "не равно" для объектов типа BankAccount
        /// </summary>
        /// <param name="acnt_1">>первый сравниваемый объект</param>
        /// <param name="acnt_2">второй сравниваемый объект</param>
        /// <returns></returns>
        public static bool operator !=(BankAccount acnt_1, BankAccount acnt_2)
        {
            if (acnt_1 is null)
                throw new ArgumentNullException($"счет {acnt_1} пуст");
            if (acnt_2 is null)
                throw new ArgumentNullException($"счет {acnt_2} пуст");
            return (acnt_1.typeOfAcnt != acnt_2.typeOfAcnt || acnt_1.balance != acnt_2.balance);
        }
        /// <summary>
        /// переопределение метода Equals для объектов типа BankAccount
        /// </summary>
        /// <param name="obj">объект сравнения</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (obj is BankAccount other_acnt)
                return (this.typeOfAcnt == other_acnt.typeOfAcnt && this.balance == other_acnt.balance);
            return false;
        }
        /// <summary>
        /// переопределение метода ToString() для объектов типа BankAccount
        /// </summary>
        /// <returns>печать информации о счете</returns>
        public override string ToString()
        {
            return $"Номер Вашего счета: {BankAccount.unicAcntNum} \r\n" +
                $"Баланс Вашего счета: {this.balance} \r\n" +
                $"Тип Вашего счета: {GetEnum(this.typeOfAcnt)}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Balance, TypeOfAccount, UnivAcntNum, AcntNum);
        }
    }
}
