using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Rotor
    {
        private int rotations = 260;
        private int adder = 0;
        private int[] inttab = new int[26];
        public Rotor(char[] arr)
        {
            int i = 0;
            foreach (char sign in arr)
            {
                inttab[i] = Convert.ToInt32(sign) - 65;
                i++;
            }

        }
        public void moveDown()
        {
            int tmp = inttab[25];
            for (int j = 25; j > 0; j--)
            {
                inttab[j] = inttab[j - 1];
            }
            inttab[0] = tmp;
            rotations--;
        }
        public void moveUp()
        {
            int tmp = inttab[0];
            for (int j = 0; j < 25; j++)
            {
                inttab[j] = inttab[j + 1];
            }
            inttab[25] = tmp;
            rotations++;
        }

        public void fakeMove()
        {
            adder++;
            adder %= 26;
        }
        public int rightImpulse(int c)
        {
            return inttab[c + adder];
        }
        public int leftImpulse(int c)
        {
            for (int i = 0; i < 26; i++) if (inttab[i] == c) return i;
            return -1;
        }
        public char[] visibleLetters()
        {
            char[] values = new char[5];
            values[0] = Convert.ToChar(inttab[24] + 65);
            values[1] = Convert.ToChar(inttab[25] + 65);
            values[2] = Convert.ToChar(inttab[0] + 65);
            values[3] = Convert.ToChar(inttab[1] + 65);
            values[4] = Convert.ToChar(inttab[2] + 65);
            return values;
        }
        public int Rotations
            {
                get
                {
                    return rotations;
                }
            }

    }
}
