using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Clases.Entity
{
    class Enemy : Entity
    {
        #region VARIABLES

        #region PRIVATE variables

        #endregion

        #region INTERNAL variables

        #endregion

        #region PUBLIC variables
        public int Dmg { get; }
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
        #region Class Constructors
        public Enemy()
        {
            MaxHp = 100;
            Hp = MaxHp;
            Dmg = 1;
        }

        public Enemy(int maxHp) : base(maxHp)
        {
            MaxHp = maxHp;
            Hp = MaxHp;
            Dmg = 1;
        }

        public Enemy(int maxHp, int hp) : base(maxHp, hp)
        {
            MaxHp = maxHp;
            Hp = hp;
            Dmg = 1;
        }
        public Enemy(int maxHp, int hp, int dmg) : base(maxHp, hp)
        {
            MaxHp = maxHp;
            Hp = hp;
            Dmg = dmg; 
        }
        #endregion

    }
}
