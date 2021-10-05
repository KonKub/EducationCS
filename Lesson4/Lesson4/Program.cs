using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        { 
            return firstName + " " + lastName +" "+patronymic;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
            Console.WriteLine(GetFullName("Петров", "С", "А"));
            Console.WriteLine(GetFullName("Сидоров", "Дормидонт", "Евлампиевич"));
            Console.WriteLine(GetFullName("Одинов", "Один", "Одинович"));

            Console.ReadKey();
        }
    }
}
