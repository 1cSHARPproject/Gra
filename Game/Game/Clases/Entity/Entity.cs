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
        private int maxHp;
        public int MaxHp
        {
            get { return maxHp; }
            protected set
            {
                if (value >= 1)
                    maxHp = value;
                else
                    maxHp = 1;
            }
        }

        private int hp;
        public int Hp
        {
            get { return hp; }
            set
            {
                if (value >= 0)
                    hp = value;
                else
                    hp = 0;
            }
        }


        #endregion
        #region STABLES

        #endregion
        #region Other declaration

        #endregion
        public virtual void SummonEntity()
        {
            maxHp = 100;
            Hp = 100;
        }
        public virtual void SummonEntity(int _maxHp)
        {
            MaxHp = _maxHp;
            Hp = _maxHp;
        }
        public virtual void SummonEntity(int _maxHp, int _hp)
        {
            MaxHp = _maxHp;
            Hp = _hp;
        }


    }
}
