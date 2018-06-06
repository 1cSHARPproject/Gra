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

        private String username;
        public String Username
        {
            get { return username; }
            protected set
            {
                if (username.Length >= 1)
                    username = value;
                else
                    username = "ERROR USERNAME TO SHORT";
            }
        }
        public Item Item1 { get; set; }
        public Item Item2 { get; set; }
        public Suit Suit { get; set; }
        public bool Alive { get; internal set; }
        
        #endregion
        #region STABLES
        #endregion
        #region Other declaration

        #endregion
        #region Class Constructors
        /// <summary>
        /// A class that represent player other parametrs will be set to deafult(item = nothing ,MaxHp&Hp 100)
        /// </summary>
        /// <param name="_username">Username of player</param>
        public Player(string _username)
        {
            username = _username;
            Item1 = Item.Nothing;
            MaxHp = 100;
            Hp = 100;
        }
        /// <summary>
        /// A class that represent player other parametrs will be set to deafult (MaxHp&Hp = 100)
        /// </summary>
        /// <param name="_username">Username of player</param>
        /// <param name="_item1">First holding item(enum Item) DEAFULT Nothing</param>
        public Player(string _username, Item _item1)
        {
            username = _username;
            Item1 = _item1;
            MaxHp = 100;
            Hp = 100;
        }
        /// <summary>
        /// A class that represent player other parametrs will be set to deafult (Hp = MaxHp)
        /// </summary>
        /// <param name="_username">Username of player</param>
        /// <param name="_item1">First holding item(enum Item) DEAFULT Nothing</param>
        /// <param name="_maxHp">Maximal vaule of hp for that player DEAFULT 100</param>
        public Player(string _username, Item _item1, int _maxHp)
        {
            username = _username;
            Item1 = _item1;
            MaxHp = _maxHp;
            Hp = _maxHp;
        }
        /// <summary>
        /// A class that represent player
        /// </summary>
        /// <param name="_username">Username of player</param>
        /// <param name="_item1">First holding item(enum Item) DEAFULT Nothing</param>
        /// <param name="_maxHp">Maximal vaule of hp for that player DEAFULT 100</param>
        /// <param name="_hp">Actual value of hp DEAFULT 100</param>
        public Player(string _username, Item _item1, int _maxHp, int _hp)
        {
            username = _username;
            Item1 = _item1;
            MaxHp = _maxHp;
            Hp = _hp;
        }
        #endregion
    }
}
