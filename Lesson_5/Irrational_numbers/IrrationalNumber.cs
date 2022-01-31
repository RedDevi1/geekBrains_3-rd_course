using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irrational_numbers
{
    public class IrrationalNumber
    {
        private int _Numerator;
        private int _Denominator;
        public int Numerator => _Numerator;
        
        public int Denominator => _Denominator;
       
        public IrrationalNumber (int numerator, int denominator)
        {
            _Denominator = denominator;
            _Numerator = numerator;
        }
        public void PrintRationalNum()
        {
            Console.WriteLine("{0:0.#####}", (double)_Numerator / (double)_Denominator);
        }
        public static IrrationalNumber operator +(IrrationalNumber num1, IrrationalNumber num2)
        {

            return new IrrationalNumber ((num2._Denominator * num1._Numerator) + (num1._Denominator * num2._Numerator), num1._Denominator * num2._Denominator);
        }
        public static IrrationalNumber operator -(IrrationalNumber num1, IrrationalNumber num2)
        {
            return new IrrationalNumber((num2._Denominator * num1._Numerator) - (num1._Denominator * num2._Numerator), num1._Denominator * num2._Denominator);
        }
        public static IrrationalNumber operator *(IrrationalNumber num1, IrrationalNumber num2)
        {
            return new IrrationalNumber(num1._Numerator * num2._Numerator, num1._Denominator * num2._Denominator);
        }
        public static IrrationalNumber operator /(IrrationalNumber num1, IrrationalNumber num2)
        {
            return new IrrationalNumber(num1._Numerator * num2._Denominator, num1._Denominator * num2._Numerator);
        }
        public static IrrationalNumber operator %(IrrationalNumber num1, IrrationalNumber num2)
        {
            return new IrrationalNumber((num1._Numerator * num2._Denominator) % (num1._Denominator * num2._Numerator), 1);
        }
        public static bool operator ==(IrrationalNumber num1, IrrationalNumber num2)
        {
            return (((double)num1._Numerator / (double)num1._Denominator) == ((double)num2._Numerator / (double)num2._Denominator));
        }
        public static bool operator !=(IrrationalNumber num1, IrrationalNumber num2)
        {
            return (((double)num1._Numerator / (double)num1._Denominator) != ((double)num2._Numerator / (double)num2._Denominator));
        }
        public static bool operator >(IrrationalNumber num1, IrrationalNumber num2)
        {
            return (((double)num1._Numerator / (double)num1._Denominator) > ((double)num2._Numerator / (double)num2._Denominator));
        }
        public static bool operator <(IrrationalNumber num1, IrrationalNumber num2)
        {
            return (((double)num1._Numerator / (double)num1._Denominator) < ((double)num2._Numerator / (double)num2._Denominator));
        }
        public static bool operator >=(IrrationalNumber num1, IrrationalNumber num2)
        {
            return (((double)num1._Numerator / (double)num1._Denominator) >= ((double)num2._Numerator / (double)num2._Denominator));
        }
        public static bool operator <=(IrrationalNumber num1, IrrationalNumber num2)
        {
            return (((double)num1._Numerator / (double)num1._Denominator) <= ((double)num2._Numerator / (double)num2._Denominator));
        }
        public static IrrationalNumber operator ++(IrrationalNumber num1)
        {
            return new IrrationalNumber(num1._Numerator + num1._Denominator, num1._Denominator);
        }
        public static IrrationalNumber operator --(IrrationalNumber num1)
        {
            if (num1._Numerator > num1._Denominator)
                return new IrrationalNumber(num1._Numerator - num1._Denominator, num1._Denominator);
            return new IrrationalNumber(-(num1._Denominator - num1._Numerator), num1._Denominator);
        }
        public static implicit operator float(IrrationalNumber num1)
        {
            return (float)num1._Numerator / (float)num1._Denominator;
        }
        public static implicit operator int(IrrationalNumber num1)
        {
            return num1._Numerator / num1._Denominator;
        }
        public override string ToString()
        {
            return ((double)_Numerator / (double)_Denominator).ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is IrrationalNumber other_num)
                return ((double)_Numerator / (double)_Denominator) == ((double)other_num._Numerator / (double)other_num._Denominator);
            return false;
        }
    }
}
