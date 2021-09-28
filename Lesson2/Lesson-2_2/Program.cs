using System;

namespace Lesson_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проще было бы сделать при помощи массива,
            //но формально мы пока про них "не знаем"

            string MonthName;

            Console.Write("Введите текущий месяц: ");
            int CurrentMonthNum = Convert.ToInt32(Console.ReadLine());

            switch (CurrentMonthNum)
            {
                case 1:
                    MonthName="Январь";
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

            Console.WriteLine("Текущий месяц " + MonthName + ".");
            Console.ReadKey();
        }
    }
}
