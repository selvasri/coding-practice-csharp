using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    class Palindromes
    {
        public static bool IsPalindrom(string str)
        {
            bool res = true;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    res = false;
            }
            return res;
        }
    }
}
