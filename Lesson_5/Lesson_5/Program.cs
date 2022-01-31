using System;
using Irrational_numbers;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = new IrrationalNumber(12, 34);
            var num2 = new IrrationalNumber(5, 8);
            var result = num1 + num2;
            var result_1 = num1 - num2;
            var result_2 = num1 * num2;
            var result_3 = num1 / num2;
            var result_4 = num1 % num2;
            var result_5 = num1 == num2;
            var result_6 = num1 != num2;
            var result_7 = num1 > num2;
            var result_8 = num1 < num2;
            var result_9 = num1++;
            var result_10 = num2--;
            var result_11 = (float)num1;
            var result_12 = (int)num1;
            result.PrintRationalNum();
            result_1.PrintRationalNum();
            result_2.PrintRationalNum();
            result_3.PrintRationalNum();
            result_4.PrintRationalNum();
            Console.WriteLine(result_5);
            Console.WriteLine(result_6);
            Console.WriteLine(result_7);
            Console.WriteLine(result_8);
            result_9.PrintRationalNum();
            result_10.PrintRationalNum();
            Console.WriteLine(result_11);
            Console.WriteLine(result_12);
            Console.WriteLine(num1.ToString());
            Console.WriteLine(num1.Equals(num2));
        }
    }
}
