using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName;

            Console.Write("Ваше имя:");
            UserName = Console.ReadLine();
            Console.WriteLine($"Привет, {UserName}, сегодня {DateTime.Now.ToShortDateString()}.");
        }
    }
}
