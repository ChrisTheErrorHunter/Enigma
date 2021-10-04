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
        public MainWindow()
        {
            InitializeComponent();
            char[] arr1 = { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };
            Rotor rotor1 = new Rotor(arr1);
        }


        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Q) QElipse.Fill = Brushes.Gold;
            if (e.Key == Key.W) WElipse.Fill = Brushes.Gold;
            if (e.Key == Key.E) EElipse.Fill = Brushes.Gold;
            if (e.Key == Key.R) RElipse.Fill = Brushes.Gold;
            if (e.Key == Key.T) TElipse.Fill = Brushes.Gold;
            if (e.Key == Key.Y) YElipse.Fill = Brushes.Gold;
            if (e.Key == Key.U) UElipse.Fill = Brushes.Gold;
            if (e.Key == Key.I) IElipse.Fill = Brushes.Gold;
            if (e.Key == Key.O) OElipse.Fill = Brushes.Gold;
            if (e.Key == Key.P) PElipse.Fill = Brushes.Gold;
            if (e.Key == Key.A) AElipse.Fill = Brushes.Gold;
            if (e.Key == Key.S) SElipse.Fill = Brushes.Gold;
            if (e.Key == Key.D) DElipse.Fill = Brushes.Gold;
            if (e.Key == Key.F) FElipse.Fill = Brushes.Gold;
            if (e.Key == Key.G) GElipse.Fill = Brushes.Gold;
            if (e.Key == Key.H) HElipse.Fill = Brushes.Gold;
            if (e.Key == Key.J) JElipse.Fill = Brushes.Gold;
            if (e.Key == Key.K) KElipse.Fill = Brushes.Gold;
            if (e.Key == Key.L) LElipse.Fill = Brushes.Gold;
            if (e.Key == Key.Z) ZElipse.Fill = Brushes.Gold;
            if (e.Key == Key.X) XElipse.Fill = Brushes.Gold;
            if (e.Key == Key.C) CElipse.Fill = Brushes.Gold;
            if (e.Key == Key.V) VElipse.Fill = Brushes.Gold;
            if (e.Key == Key.B) BElipse.Fill = Brushes.Gold;
            if (e.Key == Key.N) NElipse.Fill = Brushes.Gold;
            if (e.Key == Key.M) MElipse.Fill = Brushes.Gold;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Q) QElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.W) WElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.E) EElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.R) RElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.T) TElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.Y) YElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.U) UElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.I) IElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.O) OElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.P) PElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.A) AElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.S) SElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.D) DElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.F) FElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.G) GElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.H) HElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.J) JElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.K) KElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.L) LElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.Z) ZElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.X) XElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.C) CElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.V) VElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.B) BElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.N) NElipse.Fill = Brushes.Transparent;
            if (e.Key == Key.M) MElipse.Fill = Brushes.Transparent;
        }
    }
}
