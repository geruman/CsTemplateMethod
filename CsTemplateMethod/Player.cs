using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTemplateMethod
{
    public class Player
    {
        private int life;
        public int FireResist { get; set; }
        public int ColdResist { get; set; }
        public int ElectricityResist { get; set; }
        public Player()
        {
            life = 100;
        }
        public int GetLife()
        {
            return life;
        }
        public bool IsAlive()
        {
            if (life > 0)
            {
                return true;
            }
            return false;
        }
        public void ReceiveDamage(int amount)
        {
            life = life - amount;
        }
        public override string ToString()
        {
            return "Player Cold resist "+ColdResist+" Fire resist "+FireResist+" Electricity resist "+ElectricityResist+" Life: "+life;
        }


    }
}
