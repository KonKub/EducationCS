using System;

namespace Lesson_1_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Number = 100;
            string Result;

            for (int i=1; i<=Number; i++)
            {
                if ((i % 3 != 0) && (i % 5 != 0))
                {
                    Result = i.ToString();
                }
                else
                {
                    Result = "";
                    if (i % 3 == 0)
                    {
                        Result = "Fizz";
                    }
                    if (i % 5 == 0)
                    {
                        Result = Result + "Buzz";
                    }
                }
                Console.WriteLine(Result);
            }
        }
    }
}
