using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTemplateMethod
{
    public class LightningDamage:AbstractDamage 
    {
        public LightningDamage(int damage, Player player) : base(damage, player)
        {
        }
        public override int DamageAfterCold(int amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            
            return amount;
        }

        public override int DamageAfterElectricity(int amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            int damage = amount - player.ElectricityResist;
            if (damage < 0)
            {
                return 0;
            }
            return damage;
        }

        public override int DamageAfterFire(int amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            return amount;
        }
    }
}
