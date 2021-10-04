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
            }

        }

    }
}
