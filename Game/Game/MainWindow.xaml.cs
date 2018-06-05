
using Game.Clases.Entity;
using Game.Helpers;
using System;
using System.Windows;


namespace Game
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
        #region STABLES
            #region PRIVATE stables
            #endregion

            #region INTERNAL stables
            #endregion

            #region PUBLIC stables
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
        private Player player = new Player("marcin");
        
        /// <summary>
        /// a test method do not use
        /// </summary>
        private void metod1()
        {
            int a;
            Enemy testy = new Enemy();
            testy.SummonEntity();
            a = testy.MaxHp;
            TXT_test.Text = a.ToString();

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
            metod1(/*Convert.ToInt32(first),Convert.ToInt32(second)*/);
            TXT_test.Text = player.Username;
        }

    
        #endregion

    }
}
