using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    class ReverseString
    {
        public static string Reverse(string str)
        {
            //StringBuilder res = new StringBuilder();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    res.Append(str[i]);
            //}
            //return res.ToString();

            string res = "";
            foreach (var item in str)
            {
                res = item + res;
            }
            return res;
        }
    }
}
