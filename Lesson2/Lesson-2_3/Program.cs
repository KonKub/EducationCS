using System;

namespace Lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите целое число: ");

            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0) 
            {
                Console.WriteLine($"Число {Number} четное.");
            }
            else
            {
                Console.WriteLine($"Число {Number} нечетное.");
            }

            Console.ReadKey();
        }
    }
}
