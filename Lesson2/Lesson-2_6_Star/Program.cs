using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_6_Star
{
    class Program
    {

        static void Main(string[] args)
        {

            int WD, WorkingDaysMask=0;

            Console.WriteLine("Введите расписание работы по дням недели (1-рабочий день, 0-выходной):");

            Console.Write("Понедельник: "); WD= Convert.ToInt32(Console.ReadLine());
            if (WD != 0) WorkingDaysMask = WorkingDaysMask | 1;
            Console.Write("Вторник:     "); WD = Convert.ToInt32(Console.ReadLine());
            if (WD != 0) WorkingDaysMask = WorkingDaysMask | 2;
            Console.Write("Среда:       "); WD = Convert.ToInt32(Console.ReadLine());
            if (WD != 0) WorkingDaysMask = WorkingDaysMask | 4;
            Console.Write("Четверг:     "); WD = Convert.ToInt32(Console.ReadLine());
            if (WD != 0) WorkingDaysMask = WorkingDaysMask | 8;
            Console.Write("Пятница:     "); WD = Convert.ToInt32(Console.ReadLine());
            if (WD != 0) WorkingDaysMask = WorkingDaysMask | 16;
            Console.Write("Суббота:     "); WD = Convert.ToInt32(Console.ReadLine());
            if (WD != 0) WorkingDaysMask = WorkingDaysMask | 32;
            Console.Write("Воскресенье: "); WD = Convert.ToInt32(Console.ReadLine());
            if (WD != 0) WorkingDaysMask = WorkingDaysMask | 64;

            Console.WriteLine();
            Console.WriteLine("Расписание работы:");

            Console.Write("Понедельник: "); if ((WorkingDaysMask &  1) ==  1) Console.WriteLine("рабочий день"); else Console.WriteLine("выходной день");
            Console.Write("Вторник:     "); if ((WorkingDaysMask &  2) ==  2) Console.WriteLine("рабочий день"); else Console.WriteLine("выходной день");
            Console.Write("Среда:       "); if ((WorkingDaysMask &  4) ==  4) Console.WriteLine("рабочий день"); else Console.WriteLine("выходной день");
            Console.Write("Четверг:     "); if ((WorkingDaysMask &  8) ==  8) Console.WriteLine("рабочий день"); else Console.WriteLine("выходной день");
            Console.Write("Пятница:     "); if ((WorkingDaysMask & 16) == 16) Console.WriteLine("рабочий день"); else Console.WriteLine("выходной день");
            Console.Write("Суббота:     "); if ((WorkingDaysMask & 32) == 32) Console.WriteLine("рабочий день"); else Console.WriteLine("выходной день");
            Console.Write("Воскресенье: "); if ((WorkingDaysMask & 64) == 64) Console.WriteLine("рабочий день"); else Console.WriteLine("выходной день");

            Console.ReadKey();
        }
    }
}
