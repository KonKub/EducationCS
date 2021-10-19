using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    /*
    1. Создать консольное приложение, которое при старте выводит приветствие, 
    записанное в настройках приложения(application-scope). 
    2. Запросить у пользователя 
        имя, 
        возраст 
        род деятельности, 
        а затем сохранить данные в настройках.
    При следующем запуске отобразить эти сведения.
    3. Задать приложению версию и описание.
    */

    class Program
    {

        static void Main(string[] args)
        {
            byte Age;

            //Приветствие
            if (string.IsNullOrEmpty(Properties.Settings.Default.Greeting))
            {
                Console.WriteLine("Введите текст приветствия: ");
                Properties.Settings.Default.Greeting = Console.ReadLine();
            }
            Console.WriteLine(Properties.Settings.Default.Greeting);

            //Имя
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.Write("Ваше имя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
            }
            else
                Console.WriteLine("Имя: "+Properties.Settings.Default.UserName);

            //Возраст
            if (Properties.Settings.Default.Age==0)
            {
                Console.Write("Ваш возраст: ");
                byte.TryParse(Console.ReadLine(), out Age);
                Properties.Settings.Default.Age = Age;
            }
            else
                Console.WriteLine("Возраст: "+Properties.Settings.Default.Age);

            //Род деятельности
            if (string.IsNullOrEmpty(Properties.Settings.Default.Job))
            {
                Console.Write("Род деятельности: ");
                Properties.Settings.Default.Job = Console.ReadLine();
            }
            else
                Console.WriteLine("Род деятельности: "+Properties.Settings.Default.Job);

            Properties.Settings.Default.Save();
            Console.ReadKey();
        }
    }
}
