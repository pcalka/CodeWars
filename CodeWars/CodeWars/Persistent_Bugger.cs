using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Persistent_Bugger
    {
        //Write a function, persistence, that takes in a positive parameter num and returns
        //its multiplicative persistence, which is the number of times you must multiply 
        //the digits in num until you reach a single digit.
        //For example:
        //persistence(39) == 3  because 3*9 = 27, 2*7 = 14, 1*4=4
        //and 4 has only one digit
        public static int Persistence(long n)
        {
            int i = 0;
            while (n > 9l)
            {
                long mul = 1l;

                while (n > 0l)
                {
                    mul *= n % 10l;
                    n /= 10l;
                }

                n = mul;
                i++;
            }
            return i;
        }
    }
}
