using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Clases.Entity
{
    public class Player : Entity
    {
        #region VARIABLES

        #region PRIVATE variables

        #endregion

        #region INTERNAL variables

        #endregion

        #region PUBLIC variables
        public string Username { get; }
        public Item Item1 { get; set; }
        public bool Alive { get; internal set; }
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
		/// <summary>
        /// A class that represent player other parametrs will be set to deafult(item = nothing ,MaxHp&Hp 100)
        /// </summary>
        /// <param name="username">Username of player</param>
        public Player(string username)
        {
            Username = username;
            Item1 = Item.Nothing;
            MaxHp = 100;
            Hp = 100;
        }
        /// <summary>
        /// A class that represent player other parametrs will be set to deafult (MaxHp&Hp = 100)
        /// </summary>
        /// <param name="username">Username of player</param>
        /// <param name="item1">First holding item(enum Item) DEAFULT Nothing</param>
        public Player(string username, Item item1)
        {
            Username = username;
            Item1 = item1;
            MaxHp = 100;
            Hp = 100;
        }
        /// <summary>
        /// A class that represent player other parametrs will be set to deafult (Hp = MaxHp)
        /// </summary>
        /// <param name="username">Username of player</param>
        /// <param name="item1">First holding item(enum Item) DEAFULT Nothing</param>
        /// <param name="maxHp">Maximal vaule of hp for that player DEAFULT 100</param>
        public Player(string username, Item item1, int maxHp)
        {
            Username = username;
            Item1 = item1;
            MaxHp = maxHp;
            Hp = maxHp;
        }
        /// <summary>
        /// A class that represent player
        /// </summary>
        /// <param name="username">Username of player</param>
        /// <param name="item1">First holding item(enum Item) DEAFULT Nothing</param>
        /// <param name="maxHp">Maximal vaule of hp for that player DEAFULT 100</param>
        /// <param name="hp">Actual value of hp DEAFULT 100</param>
        public Player(string username, Item item1, int maxHp, int hp)
        {
            Username = username;
            Item1 = item1;
            MaxHp = maxHp;
            Hp = hp;
        }
        
    }
}
