using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            string PalStr = "lsdghksjbglseiukjsdgkjbgjusbfjshrggbgguefbvksjbgf";  //строка для поиска палиндромов

            int PalindromeMax=0, 
                PalindromeMaxStart=0, 
                PalindromeMaxEnd=0;

            int n, l,r;

            for (int i=0; i< PalStr.Length; i++)
                for (int j = i; j < PalStr.Length; j++)
                {
                    l = i;
                    r = j;
                    for (; ; )
                    {
                        if (PalStr[l] != PalStr[r]) break;
                        l++;
                        r--;
                        if (l >= r)  //очередной палиндром найден
                        {
                            n = j - i + 1;
                            if (n > PalindromeMax)
                            {
                                PalindromeMax = n;
                                PalindromeMaxStart = i;
                                PalindromeMaxEnd = j;
                            }
                            Console.WriteLine($"n={n}     i={i}    j={j}   {PalStr.Substring(i,n)}");//вывод всех найденных палиндромов
                            break;
                        }
                    }
                }

            Console.WriteLine("---");

            if (PalindromeMax>0)
                Console.WriteLine($"Максимальный палиндром: {PalStr.Substring(PalindromeMaxStart, PalindromeMaxEnd - PalindromeMaxStart + 1)}");
            else
                Console.WriteLine("Палиндромов не найдено.");

            Console.ReadKey();
        }
    }
}
