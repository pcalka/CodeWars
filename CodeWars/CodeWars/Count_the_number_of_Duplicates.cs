using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Count_the_number_of_Duplicates
    {
        public int DuplicateCount(string str)
        {
            var chars = new Dictionary<char, int>();
            var result = str.ToLower().Select(c => {
                if (chars.ContainsKey(c) && chars[c] == 1)
                {
                    chars[c] = 2;
                    return 1;
                }
                if (!chars.ContainsKey(c))
                {
                    chars[c] = 1;
                }
                return 0;
            }).Sum();

            return result;
        }

        public int DuplicateCount2(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(c => c.Count() > 1).Count();
        }
    }
}
