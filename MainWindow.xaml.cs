using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Enigma
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] arr0 = { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' }; // I
        char[] arr1 = { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' }; // II
        char[] arr2 = { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z', 'N', 'Y', 'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O' }; // III
        char[] arr3 = { 'E', 'S', 'O', 'V', 'P', 'Z', 'J', 'A', 'Y', 'Q', 'U', 'I', 'R', 'H', 'X', 'L', 'N', 'F', 'T', 'G', 'K', 'D', 'C', 'M', 'W', 'B' }; // III
        char[] arr4 = { 'E', 'N', 'K', 'Q', 'A', 'U', 'Y', 'W', 'J', 'I', 'C', 'O', 'P', 'B', 'L', 'M', 'D', 'X', 'Z', 'V', 'F', 'T', 'H', 'R', 'G', 'S' }; //ZWROTNY STACJONARNY!!! UKW B M4
        Rotor rotor0, rotor1, rotor2, rotor3, rotor4;
        char letter = '0';
        bool key_pressed = false;
        public MainWindow()
        {
            InitializeComponent();
            rotor4 = new Rotor(arr4); //ZWROTNY
            rotor3 = new Rotor(arr3);
            rotor2 = new Rotor(arr2);
            rotor1 = new Rotor(arr1);
            rotor0 = new Rotor(arr0);
            updateRotors(3);
            updateRotors(2);
            updateRotors(1);
            updateRotors(0);
        }

        private void tick()
        {
            rotor0.moveUp();
            updateRotors(0);
            if (rotor0.Rotations % 26 == 0)
            {
                rotor1.moveUp();
                updateRotors(1);
                if (rotor1.Rotations % 26 == 0)
                {
                    rotor2.moveUp();
                    updateRotors(2);
                }
            }
        }

        private char encode(char letter)
        {

            int iletter = Convert.ToInt32(letter) - 65;
            iletter = rotor0.rightImpulse(iletter);
            iletter = rotor1.rightImpulse(iletter);
            iletter = rotor2.rightImpulse(iletter);
            iletter = rotor3.rightImpulse(iletter);
            iletter = rotor4.rightImpulse(iletter);
            iletter = rotor3.leftImpulse(iletter);
            iletter = rotor2.leftImpulse(iletter);
            iletter = rotor1.leftImpulse(iletter);
            iletter = rotor0.leftImpulse(iletter);
            tick();
            return Convert.ToChar(iletter + 65);
        }

        
        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(key_pressed) return;
            key_pressed = true;
            if (e.Key == Key.Q) letter = encode('Q');
            if (e.Key == Key.W) letter = encode('W');
            if (e.Key == Key.E) letter = encode('E');
            if (e.Key == Key.R) letter = encode('R');
            if (e.Key == Key.T) letter = encode('T');
            if (e.Key == Key.Y) letter = encode('Y');
            if (e.Key == Key.U) letter = encode('U');
            if (e.Key == Key.I) letter = encode('I');
            if (e.Key == Key.O) letter = encode('O');
            if (e.Key == Key.P) letter = encode('P');
            if (e.Key == Key.A) letter = encode('A');
            if (e.Key == Key.S) letter = encode('S');
            if (e.Key == Key.D) letter = encode('D');
            if (e.Key == Key.F) letter = encode('F');
            if (e.Key == Key.G) letter = encode('G');
            if (e.Key == Key.H) letter = encode('H');
            if (e.Key == Key.J) letter = encode('J');
            if (e.Key == Key.K) letter = encode('K');
            if (e.Key == Key.L) letter = encode('L');
            if (e.Key == Key.Z) letter = encode('Z');
            if (e.Key == Key.X) letter = encode('X');
            if (e.Key == Key.C) letter = encode('C');
            if (e.Key == Key.V) letter = encode('V');
            if (e.Key == Key.B) letter = encode('B');
            if (e.Key == Key.N) letter = encode('N');
            if (e.Key == Key.M) letter = encode('M');
            if (letter == 'Q') QElipse.Fill = Brushes.Gold;
            if (letter == 'W') WElipse.Fill = Brushes.Gold;
            if (letter == 'E') EElipse.Fill = Brushes.Gold;
            if (letter == 'R') RElipse.Fill = Brushes.Gold;
            if (letter == 'T') TElipse.Fill = Brushes.Gold;
            if (letter == 'Y') YElipse.Fill = Brushes.Gold;
            if (letter == 'U') UElipse.Fill = Brushes.Gold;
            if (letter == 'I') IElipse.Fill = Brushes.Gold;
            if (letter == 'O') OElipse.Fill = Brushes.Gold;
            if (letter == 'P') PElipse.Fill = Brushes.Gold;
            if (letter == 'A') AElipse.Fill = Brushes.Gold;
            if (letter == 'S') SElipse.Fill = Brushes.Gold;
            if (letter == 'D') DElipse.Fill = Brushes.Gold;
            if (letter == 'F') FElipse.Fill = Brushes.Gold;
            if (letter == 'G') GElipse.Fill = Brushes.Gold;
            if (letter == 'H') HElipse.Fill = Brushes.Gold;
            if (letter == 'J') JElipse.Fill = Brushes.Gold;
            if (letter == 'K') KElipse.Fill = Brushes.Gold;
            if (letter == 'L') LElipse.Fill = Brushes.Gold;
            if (letter == 'Z') ZElipse.Fill = Brushes.Gold;
            if (letter == 'X') XElipse.Fill = Brushes.Gold;
            if (letter == 'C') CElipse.Fill = Brushes.Gold;
            if (letter == 'V') VElipse.Fill = Brushes.Gold;
            if (letter == 'B') BElipse.Fill = Brushes.Gold;
            if (letter == 'N') NElipse.Fill = Brushes.Gold;
            if (letter == 'M') MElipse.Fill = Brushes.Gold;

        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            key_pressed = false;
            if (letter == 'Q') QElipse.Fill = Brushes.Transparent;
            if (letter == 'W') WElipse.Fill = Brushes.Transparent;
            if (letter == 'E') EElipse.Fill = Brushes.Transparent;
            if (letter == 'R') RElipse.Fill = Brushes.Transparent;
            if (letter == 'T') TElipse.Fill = Brushes.Transparent;
            if (letter == 'Y') YElipse.Fill = Brushes.Transparent;
            if (letter == 'U') UElipse.Fill = Brushes.Transparent;
            if (letter == 'I') IElipse.Fill = Brushes.Transparent;
            if (letter == 'O') OElipse.Fill = Brushes.Transparent;
            if (letter == 'P') PElipse.Fill = Brushes.Transparent;
            if (letter == 'A') AElipse.Fill = Brushes.Transparent;
            if (letter == 'S') SElipse.Fill = Brushes.Transparent;
            if (letter == 'D') DElipse.Fill = Brushes.Transparent;
            if (letter == 'F') FElipse.Fill = Brushes.Transparent;
            if (letter == 'G') GElipse.Fill = Brushes.Transparent;
            if (letter == 'H') HElipse.Fill = Brushes.Transparent;
            if (letter == 'J') JElipse.Fill = Brushes.Transparent;
            if (letter == 'K') KElipse.Fill = Brushes.Transparent;
            if (letter == 'L') LElipse.Fill = Brushes.Transparent;
            if (letter == 'Z') ZElipse.Fill = Brushes.Transparent;
            if (letter == 'X') XElipse.Fill = Brushes.Transparent;
            if (letter == 'C') CElipse.Fill = Brushes.Transparent;
            if (letter == 'V') VElipse.Fill = Brushes.Transparent;
            if (letter == 'B') BElipse.Fill = Brushes.Transparent;
            if (letter == 'N') NElipse.Fill = Brushes.Transparent;
            if (letter == 'M') MElipse.Fill = Brushes.Transparent;
        }



        public void updateRotors(int num)
        {
            if (num == 3)
            {
                int rotValue = rotor3.Rotations;
                Rotor3txtU2.Text = Convert.ToString(Convert.ToChar((((rotValue - 2) % 26) + 65)));
                Rotor3txtU1.Text = Convert.ToString(Convert.ToChar((((rotValue - 1) % 26) + 65)));
                Rotor3txtCenter.Text = Convert.ToString(Convert.ToChar(((rotValue % 26) + 65)));
                Rotor3txtD1.Text = Convert.ToString(Convert.ToChar((((rotValue + 1) % 26) + 65)));
                Rotor3txtD2.Text = Convert.ToString(Convert.ToChar((((rotValue + 2) % 26) + 65)));
            }
            if (num == 2)
            {
                int rotValue = rotor2.Rotations;
                Rotor2txtU2.Text = Convert.ToString(Convert.ToChar((((rotValue - 2) % 26) + 65)));
                Rotor2txtU1.Text = Convert.ToString(Convert.ToChar((((rotValue - 1) % 26) + 65)));
                Rotor2txtCenter.Text = Convert.ToString(Convert.ToChar(((rotValue % 26) + 65)));
                Rotor2txtD1.Text = Convert.ToString(Convert.ToChar((((rotValue + 1) % 26) + 65)));
                Rotor2txtD2.Text = Convert.ToString(Convert.ToChar((((rotValue + 2) % 26) + 65)));
            }
            if (num == 1)
            {
                int rotValue = rotor1.Rotations;
                Rotor1txtU2.Text = Convert.ToString(Convert.ToChar((((rotValue - 2) % 26) + 65)));
                Rotor1txtU1.Text = Convert.ToString(Convert.ToChar((((rotValue - 1) % 26) + 65)));
                Rotor1txtCenter.Text = Convert.ToString(Convert.ToChar(((rotValue % 26) + 65)));
                Rotor1txtD1.Text = Convert.ToString(Convert.ToChar((((rotValue + 1) % 26) + 65)));
                Rotor1txtD2.Text = Convert.ToString(Convert.ToChar((((rotValue + 2) % 26) + 65)));
            }
            if (num == 0)
            {
                //char[] rotValues = rotor0.visibleLetters();
                //Rotor0txtU2.Text = Convert.ToString(rotValues[0]);
                //Rotor0txtU1.Text = Convert.ToString(rotValues[1]);
                //Rotor0txtCenter.Text = Convert.ToString(rotValues[2]);
                //Rotor0txtD1.Text = Convert.ToString(rotValues[3]);
                //Rotor0txtD2.Text = Convert.ToString(rotValues[4]);
                int rotValue = rotor0.Rotations;
                Rotor0txtU2.Text = Convert.ToString(Convert.ToChar((((rotValue - 2) % 26) + 65)));
                Rotor0txtU1.Text = Convert.ToString(Convert.ToChar((((rotValue - 1) % 26) + 65)));
                Rotor0txtCenter.Text = Convert.ToString(Convert.ToChar(((rotValue % 26) + 65)));
                Rotor0txtD1.Text = Convert.ToString(Convert.ToChar((((rotValue + 1) % 26) + 65)));
                Rotor0txtD2.Text = Convert.ToString(Convert.ToChar((((rotValue + 2) % 26) + 65)));
            }

        }

        private void Rotor2UpBtn_Click(object sender, RoutedEventArgs e)
        {
            rotor2.moveUp();
            updateRotors(2);
        }
        private void Rotor2DownBtn_Click(object sender, RoutedEventArgs e)
        {
            rotor2.moveDown();
            updateRotors(2);
        }
        private void Rotor1UpBtn_Click(object sender, RoutedEventArgs e)
        {
            rotor1.moveUp();
            updateRotors(1);
        }
        private void Rotor1DownBtn_Click(object sender, RoutedEventArgs e)
        {
            rotor1.moveDown();
            updateRotors(1);
        }
        private void Rotor0UpBtn_Click(object sender, RoutedEventArgs e)
        {
            rotor0.moveUp();
            updateRotors(0);
        }
        private void Rotor0DownBtn_Click(object sender, RoutedEventArgs e)
        {
            rotor0.moveDown();
            updateRotors(0);
        }
    }
}
