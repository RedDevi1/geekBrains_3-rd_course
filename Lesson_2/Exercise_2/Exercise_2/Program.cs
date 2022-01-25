using System;
using System.Text;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var s = Console.ReadLine();
            Console.WriteLine(TurnRoundString(s));
        }
        public static string TurnRoundString (string s)
        {
            var ss = new char[s.Length];
            var j = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ss[j] = s[i];
                j++;
            }
            StringBuilder sb = new StringBuilder(ss.Length);
            string result = sb.Append(ss).ToString();
            return result;
        }
    }
}
