using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsTest
{
    class HeadOnTheWrongWay
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            //your code here
            string[] array = { "one", "two", "three" };

            foreach (string x in arr)
            {
                if (x.Contains("head") || x.Contains("top") || x.Contains("upper") || x.Contains("ground") || x.Contains("Souther"))
                {
                    array[0] = x;
                }
                if (x.Contains("body") || x.Contains("middle") || x.Contains("torso") || x.Contains("rainbow"))
                {
                    array[1] = x;
                }
                if (x.Contains("tail") || x.Contains("tails") || x.Contains("bottom") || x.Contains("lower") || x.Contains("sky"))
                {
                    array[2] = x;
                }
            }
            return array;
        }
    }
}
