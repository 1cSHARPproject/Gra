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
        private short test;
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
        /// <summary>
        /// a test method do not use
        /// </summary>
        public void metod1()
        {
            var testy = test;
            for (int i = 0; i < 5; i++)
                testy++;
            TXT_test.Text = testy.ToString();
        }
        #endregion

    }
}
