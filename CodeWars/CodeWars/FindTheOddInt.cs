using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class FindTheOddInt
    {
    //Given an array, find the integer that appears an odd number of times.
    //There will always be only one integer that appears an odd number of times.

        public int find_it(int[] seq)
        {
            Dictionary<int, int> ValueList = new Dictionary<int, int>();
            for (int i = 0; i < seq.Length; i++)
            {
                if (ValueList.ContainsKey(seq[i]))
                {
                    ValueList[seq[i]]++;
                }
                else ValueList.Add(seq[i], 1);
            }
            var NumberSought = ValueList.Where(c => c.Value % 2 == 1).FirstOrDefault();
            return NumberSought.Key;
        }
    }
}
