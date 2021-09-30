using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 10;
            const int Y = 10;
            const int ShipsNum = 10;                              //количество кораблей
            int[] ship = new int[ShipsNum] {4,3,3,2,2,2,1,1,1,1}; //палубы кораблей
            int[,] A = new int[X,Y];                              
            Random rand = new Random();

            for (int i = 0; i < X; i++)
                for (int j = 0; j < Y; j++)
                    A[i, j] = 0;

            bool TryAgain;
            int orient;
            int posX;
            int posY;          //ShipsNum
            for (int n = 0; n < ShipsNum; n++) {
                for (; ; ) {
                    TryAgain = false;
                    orient = rand.Next(2); //0 - горизонтальное, 1 - вертикальное расположение корабля
                    posX = rand.Next(X);
                    posY = rand.Next(Y);
                    if (orient == 0)
                    {
                        if (posX > X - ship[n] - 1) posX = X - ship[n];
                        for (int i = posX; i < posX + ship[n]; i++)  //Проверяем занято место или нет
                            if (A[i, posY] != 0) { TryAgain = true; break; }
                        if (TryAgain) continue;
                    }
                    else
                    {
                        if (posY > Y - ship[n] - 1) posY = Y - ship[n];
                        for (int i = posY; i < posY + ship[n]; i++)  //Проверяем занято место или нет
                            if (A[posX, i] != 0) { TryAgain = true; break; }
                        if (TryAgain) continue;
                    }

                    //резервирование места вокруг корабля
                    for (int i = 0; i < ship[n]; i++)
                    {
                        if (orient == 0)
                        {
                            for (int j = posX + i - 1; j <= posX + i+1; j++)
                                for (int k = posY-1; k <= posY+1; k++)
                                    if (j >= 0 && j < X && k>=0 && k<Y) A[j, k] = 2;
                        }
                        else 
                        {
                            for (int j = posY + i - 1; j <= posY + i+1; j++)
                                for (int k = posX-1; k <= posX+1; k++)
                                    if (k >= 0 && k < X && j>=0 && j<Y) A[k, j] = 2;
                        }
                    }
                    //ставим корабль
                    for (int i = 0; i < ship[n]; i++)
                    {
                        if (orient == 0) A[posX + i, posY] = 1;
                        else             A[posX, posY + i] = 1;
                    }
                    break;
                }
            }

            char[] CA = new char[3] {'O', //свободные клетки
                                     'X', //корабль
                                     'O'};//место вокруг корабля
            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++) Console.Write(" "+ CA[A[j,i]]);
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
