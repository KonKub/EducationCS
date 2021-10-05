using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_3
{
    class Program
    {
        enum Seasons {
            Winter = 1, 
            Spring, 
            Summer, 
            Autumn
        }

        static Seasons GetSeason(int AMonth) 
        {
            if (AMonth == 12 || AMonth ==1 || AMonth == 2) return Seasons.Winter;
            if (AMonth >=  3 && AMonth <=  5) return Seasons.Spring;
            if (AMonth >=  6 && AMonth <=  8) return Seasons.Summer;
            if (AMonth >=  9 && AMonth <= 11) return Seasons.Autumn;
            return 0; //ошибка ввода номера месяца
        }

        static string GetSeasonRU(Seasons ASeason)
        {
            if (ASeason == Seasons.Winter) return "Зима";
            if (ASeason == Seasons.Spring) return "весна";
            if (ASeason == Seasons.Summer) return "лето";
            if (ASeason == Seasons.Autumn) return "осень";

            return "Ошибка определения сезона.";
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            string SMonth = Console.ReadLine();

            int NMonth;
            bool Error = false;

            if (Int32.TryParse(SMonth, out NMonth))
            {
                if (NMonth < 1 || NMonth > 12)
                    Error = true;
                else
                    Console.WriteLine(GetSeasonRU(GetSeason(NMonth)));
            }
            else
            {
                Error = true;
            }

            if (Error) Console.WriteLine("Ошибка: введите число от 1 до 12.");

            Console.ReadKey();
        }
    }
}
