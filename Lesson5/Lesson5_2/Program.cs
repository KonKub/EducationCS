using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            string FileName = "startup.txt";

            File.AppendAllText(FileName, DateTime.Now.ToLongTimeString());
            File.AppendAllText(FileName, Environment.NewLine);
        }
    }
}
