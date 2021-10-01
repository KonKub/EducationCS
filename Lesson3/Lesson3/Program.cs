using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Размерности массива
            const int X = 10;
            const int Y = 10;

            //максимальная размерность
            int MaxDim = X >= Y ? X : Y;
            
            Random rand = new Random();


            int[,] A = new int[X, Y];

            for (int i = 0; i < X; i++)
                for (int j = 0; j < Y; j++)
                    A[i, j] = rand.Next(10);

            for (int i = 0; i < MaxDim; i++)
                Console.WriteLine(A[i,i]);

            Console.ReadKey();
        }
    }
}
