using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class SortOdd
    {
        public int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] % 2 == 1 && array[j] % 2 == 1)
                        if (array[i] > array[j])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                }
            }
            return array;
        }
    }
}
