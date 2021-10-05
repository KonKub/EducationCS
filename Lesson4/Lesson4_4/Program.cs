using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_4
{
    class Program
    {
        static int X = 0; //заданное значение числа Фибоначчи (>=0)

        static int F0 = 0, F1 = 1;
        static int F=0, n=0;

        static void Fibonacci()
        {
            if (n >= X-1) return;
            else
            {
                F = F0 + F1;
                F0 = F1;
                F1 = F;

                n++;
                Fibonacci();
            }
        }

        static void Main(string[] args)
        {
            X = 7;

            if (X == 0) F = 0;
            else
                if (X == 1) F = 1;
                else 
                    Fibonacci();

            Console.WriteLine($"{X} : {F}");
            Console.ReadKey();
        }
    }
}
