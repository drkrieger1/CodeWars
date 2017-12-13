using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsTest
{
    class Prime
    {
        public static bool IsPrime(int n)
        {
            int num = 0;
            if (n == 1)
            {
                return false;
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    num++;
                }
            }

            if (0 < num && num < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
