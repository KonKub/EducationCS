using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A1 = new[] { 1,2,2};                  //Массив 1
            int[] A2 = new[] { 1};                      //Массив 2

            int[] A = new int[A1.Length + A2.Length];   //Объединенный массив
            float M;

            for (int i = 0; i < A1.Length; i++)
                A[i] = A1[i];
            int n = A1.Length;
            for (int i = 0; i < A2.Length; i++)
            {
                A[n] = A1[i];
                n++;
            }

            if (A.Length > 0)
            {
                Array.Sort(A);
                if (A.Length % 2 == 0)
                {
                    M = (A[A.Length / 2] + A[A.Length / 2 - 1]);
                    M = M / 2f;
                }
                else
                {
                    M = A[A.Length / 2];
                }

                Console.WriteLine("Медиана = "+M);
            }
            else {
                Console.WriteLine("Невозможно вычислить медиану - длина массива = 0.");
            }

            Console.ReadKey();
        }
    }
}
