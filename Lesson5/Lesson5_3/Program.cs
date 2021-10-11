using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
            Console.Write("Введите произвольный набор чисел (0 до 255) через пробел: ");
            string SNums = Console.ReadLine();

            string FileName = "file.bin";
            string[] SNumsArr=SNums.Split(' ');

            byte[] N = new byte[SNumsArr.Length];
            bool Error = false;
            for (int i=0; i< SNumsArr.Length; i++)
            {
                if (!byte.TryParse(SNumsArr[i], out N[i]))
                {
                    Error = true;
                    break;
                }
            }
            if (!Error)
            {
                File.WriteAllBytes(FileName, N);
                Console.WriteLine("Числа успешно записаны в файл "+ FileName+".");
            }
            else
            {
                Console.WriteLine("Ошибка ввода чисел.");
            }
            Console.ReadKey();
        }
    }
}
