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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region VARIABLES

        #region PRIVATE variables
        private int test=1; //testowa zmienna
        #endregion

        #region INTERNAL variables

        #endregion

        #region PUBLIC variables

        #endregion

        #endregion

        #region Konstruktor
        public MainWindow()
        {
            InitializeComponent();
            metod1();
        }
        #endregion

        #region Metods
        Player player = new Player();
        
        /// <summary>
        /// a test method do not use
        /// </summary>
        private void metod1()
        {
            
            
        }
        /// <summary>
        /// Second test method do not use
        /// </summary>
        /// <param name="a">test param</param>
        /// <param name="b">test param</param>
        /// <returns>test returns</returns>
        private int metod2(int a, int b)
        {
            var one = a;
            var two = b;
            var zwrot = a * a * a + b;
            return zwrot;
        }
        /// <summary>
        /// Test method that run when user click button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_liczenie_click(object sender, RoutedEventArgs e)
        {
            var first = TXT_pierwszywarunek.Text;
            var second = TXT_drugiwarunek.Text;
            var testy = metod2(Convert.ToInt32(first),Convert.ToInt32(second));
            TXT_test.Text = testy.ToString();
        }
        #endregion
    }
}
