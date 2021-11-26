using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTemplateMethod
{
    public abstract class AbstractDamage
    {
        protected Player player;
        protected int damageAmount;
        public AbstractDamage(int damageAmount,Player player)
        {
            this.player = player;
            this.damageAmount = damageAmount;
        }
        public void DoDamage()
        {
            int totalDamage = DamageAfterFire(damageAmount);
            totalDamage = DamageAfterCold(totalDamage);
            totalDamage = DamageAfterElectricity(totalDamage);
            player.ReceiveDamage(totalDamage);
        }
        public abstract int DamageAfterFire(int amount);
        public abstract int DamageAfterCold(int amount);
        public abstract int DamageAfterElectricity(int amount);
    }
}
