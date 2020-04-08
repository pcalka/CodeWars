using System.Linq;

namespace CodeWars
{
    class Replace_With_Alphabet_Position
    {
        //Welcome.
        //In this kata you are required to, given a string, replace every letter with 
        //its position in the alphabet.
        //If anything in the text isn't a letter, ignore it and don't return it.
        //"a" = 1, "b" = 2, etc.
        //Example
        //Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
        //Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)

        public string AlphabetPosition(string text)
        {
            if (text != null || text.Length > 0)
            {
                string NumericText = "";
                text = text.ToLower();
                foreach (char c in text)
                {
                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                        NumericText += c - 96 + " ";
                }
                NumericText = NumericText.TrimEnd();
                return NumericText;
            }
            else return "";
        }

        public string AlphabetPositionWithLinq(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(c => c - 'a' + 1));
        }
    }
}
