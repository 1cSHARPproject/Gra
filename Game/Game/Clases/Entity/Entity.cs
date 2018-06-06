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
                if (value > 1)
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
                if (value > 0)
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
        /// <summary>
        /// 
        /// </summary>
        public virtual void SummonEntity()
        {
            MaxHp = 100;
            Hp = 100;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxHp"></param>
        public virtual void SummonEntity(int maxHp)
        {
            MaxHp = maxHp;
            Hp = maxHp;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxHp"></param>
        /// <param name="hp"></param>
        public virtual void SummonEntity(int maxHp, int hp)
        {
            MaxHp = maxHp;
            Hp = hp;
        }


    }
}
