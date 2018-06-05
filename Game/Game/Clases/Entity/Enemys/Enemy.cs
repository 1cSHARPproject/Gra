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
            set { dmg = value; }
        }

        #endregion
        #region STABLES
        #endregion
        #region Other declaration

        #endregion
        #region Metods
        public override void SummonEntity()
        {
            base.SummonEntity();
            Dmg = 1;
        }

        public override void SummonEntity(int _maxHp)
        {
            base.SummonEntity(_maxHp);
            Dmg = 1;
        }

        public override void SummonEntity(int _maxHp, int _hp)
        {
            base.SummonEntity(_maxHp, _hp);
            Dmg = 1;
        }
        public virtual void SummonEntity(int _maxHp, int _hp, int _dmg)
        {
            base.SummonEntity(_maxHp, _hp);
            Dmg = _dmg; 
        }
        #endregion

    }
}
