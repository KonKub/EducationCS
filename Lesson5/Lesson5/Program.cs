using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите что-нибудь: ");
            string Somwthing = Console.ReadLine();

            File.WriteAllText("text.txt", Somwthing);
        }
    }
}
