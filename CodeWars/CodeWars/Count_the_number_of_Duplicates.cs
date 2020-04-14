using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Count_the_number_of_Duplicates
    {
//Count the number of Duplicates
//Write a function that will return the count of distinct case-insensitive alphabetic 
//characters and numeric digits that occur more than once in the input string. 
//The input string can be assumed to contain only alphabets(both uppercase 
//and lowercase) and numeric digits.
//Example
//"abcde" -> 0 # no characters repeats more than once
//"aabbcde" -> 2 # 'a' and 'b'
//"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
//"indivisibility" -> 1 # 'i' occurs six times
//"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice

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
