using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    class ReverseInt
    {
        public static int Reverse(int number)
        {
            //if(number >= 0)
            //    return Convert.ToInt32(ReverseString.Reverse(number.ToString()));
            //return Convert.ToInt32(ReverseString.Reverse((number*-1).ToString()))*-1;

            return Convert.ToInt32(ReverseString.Reverse((number * Math.Sign(number)).ToString())) * Math.Sign(number);
        }
    }
}
