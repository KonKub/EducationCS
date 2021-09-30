using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RecNum = 5;
            string[,] PhoneDir = new string[RecNum, 2];

            Console.WriteLine("Введите контакты в телефонный справочник:");
            for (int i = 0; i < RecNum; i++)
            {
                Console.WriteLine($"Запись {i+1} из {RecNum}:"); 
                Console.Write("    Имя: ");                     PhoneDir[i, 0] = Console.ReadLine();
                Console.Write("    Номер телефона / e-mail: "); PhoneDir[i, 1] = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("Телефонный справочник заполнен.");
            Console.ReadKey();
        }
    }
}
