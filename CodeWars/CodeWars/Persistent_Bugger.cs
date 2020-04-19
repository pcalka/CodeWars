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
            while (n > 9L)
            {
                long mul = 1L;

                while (n > 0L)
                {
                    mul *= n % 10L;
                    n /= 10L;
                }

                n = mul;
                i++;
            }
            return i;
        }
    }
}
