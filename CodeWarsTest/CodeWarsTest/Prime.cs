using System;
using System.Collections.Generic;
using System.Linq;
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
        //Refactor
         public static bool IsPrime2(int n)
        {
            int num = 0;
            if (n == 1)
            {
                return false;
            }

            IEnumerable<int> range = Enumerable.Range(2, n);

            foreach(int x in range)
            {
                if(n % x == 0)
                {
                    num++;
                }
            }
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        num++;
            //    }
            //}

            if (0 < num && num < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrime3(int n)
        {
            //if (number < 2) return false;
            //if (number == 2) return true;
            //if (number % 2 == 0) return false;
            //for (int i = 3; i * i <= number; i += 2)
            //    if (number % i == 0) return false;
            //return true;

            if (n < 2) { return false; }
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for(int i = 3; i * i <= n; i += 2)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
    
}
