using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_4
{
    class Program
    {

        static void DirTreeRecursion(string root)
        {
            string[] files = Directory.GetFiles(root, "*.*");
            string[] dirs = Directory.GetDirectories(root);

            Console.WriteLine(root);
            if (files != null)
            {
                foreach (string file in files)
                {
                    Console.WriteLine("   " + Path.GetFileName(file));
                }
            }
            if (dirs != null)
            {
                foreach (string dir in dirs)
                {
                    DirTreeRecursion(dir);
                }
            }
        }

        static void DirTreeNoRecursion(string root)
        {
            string[] files = Directory.GetFiles(root, "*.*");

            Console.WriteLine(root);
            if (files != null)
            {
                foreach (string file in files)
                {
                    Console.WriteLine("   " + Path.GetFileName(file));
                }
            }
        }

        static void Main(string[] args)
        {
            //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

            string Dir = @"f:\Dir_root";

            Console.WriteLine("Вывод рекурсивным методом:");
            Console.WriteLine("");
            if (Directory.Exists(Dir)) // каталог существует
            {
                DirTreeRecursion(Dir);
            }
            else 
            {
                Console.WriteLine("Ошибка. Возможно каталога не существует.");
            }
            Console.WriteLine("");

            Console.WriteLine("Вывод без рекурсии:");
            Console.WriteLine("");
            if (Directory.Exists(Dir)) // каталог существует
            {
                DirTreeNoRecursion(Dir);
                string[] dirs = Directory.GetDirectories(Dir);
                if (dirs != null)
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        DirTreeNoRecursion(dirs[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Возможно каталога не существует.");
            }

            Console.ReadKey();
        }
    }
}
