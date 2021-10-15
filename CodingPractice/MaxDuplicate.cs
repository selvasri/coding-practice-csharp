using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    class MaxDuplicate
    {
        public static char GetMaxDuplicate(string str)
        {
            Dictionary<char, int> strDict = new Dictionary<char, int>();
            int maxCount = 0;
            char maxDuplicate = char.MinValue;
            //foreach (var item in str)
            //{
            //    if (strDict.ContainsKey(item))
            //        strDict[item]++;
            //    else
            //        strDict.Add(item, 1);
            //}

            foreach (var item in str)
            {
                if (!strDict.ContainsKey(item))
                    strDict[item] = 0;
                strDict[item]++;
            }

            foreach(var item in strDict)
            {
                if(strDict[item.Key] > maxCount)
                {
                    maxDuplicate = item.Key;
                    maxCount = item.Value;
                }
                    
            }

            return maxDuplicate;
        }
    }
}
