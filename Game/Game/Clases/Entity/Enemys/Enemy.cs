using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Clases.Entity
{
    public class Enemy : Entity
    {
        #region VARIABLES
        private int dmg;
        public virtual int Dmg
        {
            get { return dmg; }
            internal set
            {
                if (value > 1)
                    dmg = value;
                else
                    dmg = 1;
            }
        }

        private int atackRange;
        public int AtackRange
        {
            get { return atackRange; }
            internal set
            {
                if (value > 1)
                    atackRange = value;
                else
                    atackRange = 1;
            }
        }


        #endregion
        #region STABLES
        #endregion
        #region Other declaration

        #endregion
        #region Metods
        /// <summary>
        /// 
        /// </summary>
        public override void SummonEntity()
        {
            base.SummonEntity();
            Dmg = 1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxHp"></param>
        public override void SummonEntity(int maxHp)
        {
            base.SummonEntity(maxHp);
            Dmg = 1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxHp"></param>
        /// <param name="hp"></param>
        public override void SummonEntity(int maxHp, int hp)
        {
            base.SummonEntity(maxHp, hp);
            Dmg = 1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxHp"></param>
        /// <param name="hp"></param>
        /// <param name="dmg"></param>
        public virtual void SummonEntity(int maxHp, int hp, int dmg)
        {
            base.SummonEntity(maxHp, hp);
            Dmg = dmg; 
        }
        #endregion

    }
}
