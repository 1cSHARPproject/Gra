using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Clases.Entity
{
    public class Entity
    {
        #region VARIABLES

        #region PRIVATE variables

        #endregion

        #region INTERNAL variables

        #endregion

        #region PUBLIC variables
        public int MaxHp { get; internal set; }
        public int Hp { get; set; }
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
        public Entity()
        {
            MaxHp = 100;
            Hp = 100;
        }
        public Entity(int maxHp)
        {
            MaxHp = maxHp;
            Hp = 100;
        }
        public Entity(int maxHp, int hp)
        {
            MaxHp = maxHp;
            Hp = hp;
        }

    }
}
