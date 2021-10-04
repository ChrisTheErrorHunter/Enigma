using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Rotor
    {
        private int position = 0;
        private int[] inttab = new int[26];
        public Rotor(char[] arr)
        {
            int i = 0;
            foreach(char sign in arr)
            {
                inttab[i] = Convert.ToInt32(sign) - 65;
                Console.WriteLine(inttab[i]);
                i++;
            }

        }
        public void moveUp()
        {
            int tmp = inttab[25];
            for(int j = 1; j < 26; j++)
            {
                inttab[j] = inttab[j - 1];
            }
            inttab[0] = tmp;
            //Console.WriteLine(inttab);
        }

    }
}
