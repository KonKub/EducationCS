using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_5_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tmin, Tmax;
            float Taverage;
            string MonthName;

            Console.Write("Введите минимальную температуру за сутки: ");
            Tmin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную температуру за сутки: ");
            Tmax = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите текущий месяц: ");
            int CurrentMonthNum = Convert.ToInt32(Console.ReadLine());

            Taverage = (float)(Tmin + Tmax) / 2;

            switch (CurrentMonthNum)
            {
                case 1:
                    MonthName = "Январь";
                    break;
                case 2:
                    MonthName = "Февраль";
                    break;
                case 3:
                    MonthName = "Март";
                    break;
                case 4:
                    MonthName = "Апрель";
                    break;
                case 5:
                    MonthName = "Май";
                    break;
                case 6:
                    MonthName = "Июнь";
                    break;
                case 7:
                    MonthName = "Июль";
                    break;
                case 8:
                    MonthName = "Август";
                    break;
                case 9:
                    MonthName = "Сентябрь";
                    break;
                case 10:
                    MonthName = "Октябрь";
                    break;
                case 11:
                    MonthName = "Ноябрь";
                    break;
                case 12:
                    MonthName = "Декабрь";
                    break;
                default:
                    MonthName = $"неизвестен. Ошибка ввода номера месяца: ({CurrentMonthNum})";
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine(String.Format("Средняя температура за сутки: {0:f1}", Taverage));
            Console.WriteLine("Текущий месяц " + MonthName + ".");
            if (Taverage>0 && (CurrentMonthNum==12 || CurrentMonthNum == 1 || CurrentMonthNum == 2))
            {
                Console.WriteLine("Дождливая зима");
            }
            Console.ReadKey();
        }
    }
}
