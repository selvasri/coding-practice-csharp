using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    class FizzBuzz
    {
        public static void PrintFizzBuzz(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                StringBuilder res = new StringBuilder();

                if(i % 3 !=0 && i%5 !=0) res.Append(i);
                if (i % 3 == 0) res.Append("Fizz");
                if (i % 5 == 0) res.Append("Buzz");

                Console.WriteLine(res);
            }
        }
    }
}
