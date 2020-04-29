using System;
using System.Linq;

namespace CodeWars
{
    class BitCounting
    {
        //Write a function that takes an integer as input, and returns the number of bits that are equal 
        //to one in the binary representation of that number.You can guarantee that input is non-negative.
        //Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
        public int CountBits(int n)
        {
            var BinaryForm = Convert.ToString(n, 2);
            int Counter = 0;
            for (int i = 0; i < BinaryForm.Length; i++)
            {
                if (BinaryForm[i] == '1') Counter++;
            }
            return Counter;
        }

        public int CountBitsWithLinq(int n)
        {
            return Convert.ToString(n, 2).Count(c => c == '1');
        }
    }
}
