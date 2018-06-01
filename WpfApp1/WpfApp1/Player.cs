using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Clases
{
    public class Player
    {
        #region VARIABLES

        #region PRIVATE variables

        #endregion

        #region INTERNAL variables

        #endregion

        #region PUBLIC variables
        public string Username { get; }
        public int MaxHp { get; set; }
        public int Hp { get; set; }
        public int Item1 { get; set;  }
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

        public Player(string username )
        {
            Username = username;
        }

    }
}
