using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str;
            string[] SNumbers;

            Console.Write("Введите числа через пробел: ");
            Str=Console.ReadLine();

            SNumbers = Str.Split(' ');

            int Sum = 0;
            int N;
            bool Error = false;
            foreach (string S in SNumbers)
            {
                if (Int32.TryParse(S, out N))
                {
                    Sum = Sum + N;
                }
                else
                {
                    Error = true;
                    break;
                }
            }

            if (!Error) 
                Console.WriteLine("Сумма введенных чисел: "+Sum);
            else
                Console.WriteLine("Ошибка ввода чисел.");

            Console.ReadKey();
        }
    }
}
