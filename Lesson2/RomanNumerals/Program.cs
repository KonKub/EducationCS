using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {

            string RomanNumerals = "LXXXI";//"MMMCMXCIX";
            int DecimalNumerals = 0;

            int[,] d = new int[10,2];
            int n = 0;
            int v;

            Console.WriteLine("Введите число римскими цифрами.");
            Console.WriteLine("Допустимые символы: I,V,X,L,C,D,M,i,v,x,l,c,d,m.");
            Console.Write("> ");
            RomanNumerals = Console.ReadLine();

            RomanNumerals = RomanNumerals.ToUpper();
            for (int i=0; i < RomanNumerals.Length; i++)
            {
                switch (RomanNumerals[i])
                {
                    case 'I': v = 1; break;
                    case 'V': v = 5; break;
                    case 'X': v = 10; break;
                    case 'L': v = 50; break;
                    case 'C': v = 100; break;
                    case 'D': v = 500; break;
                    case 'M': v = 1000; break;
                    default:  v = 0; break;
                }
                if (d[n,0]==v)
                {
                    d[n, 0] = v;
                    d[n, 1] = d[n, 1] + v;
                }
                else
                {
                    n++;
                    d[n, 0] = v;
                    d[n, 1] = d[n, 1] + v;
                }
            }

            if (n==1)
            {
                DecimalNumerals = d[1, 1];
            }
            else
            {
                int k = n;

                do
                {
                    if (d[k, 0] > d[k - 1, 0])
                    {
                        DecimalNumerals = DecimalNumerals + d[k, 1] - d[k-1, 1];
                    }
                    else
                    {
                        DecimalNumerals = DecimalNumerals + d[k, 1] + d[k - 1, 1];
                    }
                    k = k - 2;
                    if (k == 1)
                    {
                        DecimalNumerals = DecimalNumerals + d[1, 1];
                        k = 0;
                    }
                } while (k > 0);
            }

            Console.WriteLine("Десятичное значение: " + DecimalNumerals); 
            Console.ReadKey();
        }
    }
}
