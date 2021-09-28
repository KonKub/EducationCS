using System;

namespace Lesson_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string CompanyName = "ООО \"Рога и копыта\"";
            int KKM = 12345;
            long INN = 574637345;
            int INNnum = 7745;
            int SellNum = 6521;

            string GoodsName = "Товар 1";
            float GoodsQuantity = 2f;
            float GoodsPrice = 534.75f;

            float Discount = 32.34f;


            Console.WriteLine($"                {CompanyName}");
            Console.WriteLine("                  ДОБРО ПОЖАЛОВАТЬ!");
            Console.WriteLine("KKM {0:D8}          ИНН {1:D12} #{2:D4}",KKM,INN,INNnum);
            Console.WriteLine("{0:d} {0:t}", DateTime.Now);
            Console.WriteLine("Продажа                                N{0:D4}", SellNum);
            Console.WriteLine("{0,-20} {1,10:F3} X {2,10:F2}", GoodsName, GoodsQuantity, GoodsPrice);
            Console.WriteLine("Скидка  {0,36:F2}", Discount);
            Console.WriteLine("============================================");
            Console.WriteLine("ИТОГ {0,39:F2}", GoodsQuantity * GoodsPrice - Discount);

            Console.ReadKey();
        }
    }
}
