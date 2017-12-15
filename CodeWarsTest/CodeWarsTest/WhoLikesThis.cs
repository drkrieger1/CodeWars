using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsTest
{
    class WhoLikesThis
    {
        public string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }

            if (name.Length > 0 && name.Length < 4)
            {
                if (name.Length == 1)
                {
                    return $"{name[0]} likes this";
                }
                if (name.Length == 2)
                {
                    return $"{name[0]} and {name[1]} like this";
                }

                return $"{name[0]}, {name[1]} and {name[2]} like this";
                
            }
            else
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }

    }
}
