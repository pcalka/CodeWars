﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class TwoSum
    {
        //Write a function that takes an array of numbers(integers for the tests) and a
        //target number.It should find two different items in the array that, when added 
        //together, give the target value. The indices of these items should then be 
        //returned in a tuple like so: (index1, index2).
        //For the purposes of this kata, some tests may have multiple answers; any valid solutions 
        //will be accepted. The input will always be valid (numbers will be an array of 
        //length 2 or greater, and all of the items will be numbers; target will always be 
        //the sum of two different items from that array).
        //Based on: http://oj.leetcode.com/problems/two-sum/
        //twoSum[1, 2, 3] 4 === (0, 2)

        public  int[] FindIndex(int[] numbers, int target)
        {
            int[] FoundNumbers = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        FoundNumbers[0] = i;
                        FoundNumbers[1] = j;
                    }
                }
            }
            return FoundNumbers;
        }
    }

}
