using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class BuildTower
    {
        //Build Tower by the following given argument:
        //number of floors(integer and always greater than 0).
        //Tower block is represented as *
        //Python: return a list;
        //JavaScript: returns an Array;
        //C#: returns a string[];
        //Lua: returns a Table;
        //Have fun!
        //for example, a tower of 3 floors looks like below
        //[
        //  '  *  ',
        //  ' *** ',
        //  '*****'
        //]
        public string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];
            string str = string.Empty;
            int counter = nFloors;
            for (int i = 0; i < nFloors; i++)
            {
                str = new String(' ', counter - 1);
                str = str + new String('*', ((i + 1) * 2) - 1);
                str = str + new String(' ', counter - 1);
                counter--;
                tower[i] = str;
            }
            return tower;
        }
    }
}
