using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите что-нибудь: "); 
            string S = Console.ReadLine();

            for (int i = S.Length - 1; i >= 0; i--)
                Console.Write(S[i]);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
