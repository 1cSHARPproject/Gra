using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Clases
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
        public Item1 Item1 { get; set; }
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

        #endregion

        public Player(string username)
        {
            Username = username;
        }
        public Player(string username, Item1 item1)
        {
            Username = username;
            Item1 = item1;
        }
        public Player(string username, Item1 item1, int maxHp)
        {
            Username = username;
            Item1 = item1;
            MaxHp = maxHp;
        }
        public Player(string username, Item1 item1, int maxHp, int hp)
        {
            Username = username;
            Item1 = item1;
            MaxHp = maxHp;
            Hp = hp;
        }
    }
}
