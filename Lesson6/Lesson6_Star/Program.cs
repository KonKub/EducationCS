using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поиск минимального положительного пропущенного числа в массиве

            int[] Arr = new int[] {5,6,0,-2,3,1,3,5,4};
            int N=1;

            Array.Sort(Arr);

            for (int i = 0; i < Arr.Length; i++)
                if (Arr[i] > 0)
                {
                    if (N == Arr[i]) N++;
                }
            Console.WriteLine("Результат: " + N);
            Console.ReadKey();
        }
    }
}
