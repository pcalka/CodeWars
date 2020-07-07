using System.Linq;

namespace CodeWars
{
    public class _1Array
    {
        //Given an array of integers of any length, return an array that has 1 added 
        //to the value represented by the array.
        //-the array can't be empty
        //-only non-negative, single digit integers are allowed
        //Return nil (or your language's equivalent) for invalid inputs.
        //Examples
        //For example the array[2, 3, 9] equals 239, adding one would return the array [2, 4, 0].
        //[4, 3, 2, 5] would return [4, 3, 2, 6]

        public int[] UpArray(int[] num)
        {
            if (num.Length == 0 || num.Any(x => x < 0 || x > 9))
            {
                return null;
            }

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == 9)
                {
                    num[i] = 0;
                }
                else
                {
                    num[i]++;
                    return num;
                }
            }
            return new[] { 1 }.Concat(num).ToArray();
        }
    }
}
