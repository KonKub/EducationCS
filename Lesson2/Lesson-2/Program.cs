using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tmin, Tmax;
            float Taverage;

            Console.Write("Введите минимальную температуру за сутки: ");
            Tmin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную температуру за сутки: ");
            Tmax = Convert.ToInt32(Console.ReadLine());

            Taverage = (float)(Tmin + Tmax) / 2;
            Console.WriteLine("");
            Console.WriteLine(String.Format("Средняя температура за сутки: {0:f1}", Taverage));
            Console.ReadKey();
        }
    }
}
