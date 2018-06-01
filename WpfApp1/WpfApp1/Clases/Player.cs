using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Player
    {
        #region VARIABLES

        #region PRIVATE variables
        private string Username;
        private int MaxHp;
        private int Hp;
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
        #region Other declaration
        enum Item1 { Hammer, Sword, FireExinguisher }
        enum Item2 { Hammer, Sword, FireExinguisher }
        enum Suit { SpaceSuit,ArmoredSpaceSuit}
        #endregion

        public Player(string username)
        {
            Username = username;
        }
        public string getUsername()
        {
            return Username;
        }
    }
}
