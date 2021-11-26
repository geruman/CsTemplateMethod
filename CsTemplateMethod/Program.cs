using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.ColdResist = 5;
            player.FireResist = 7;
            player.ElectricityResist = 15;
            Console.WriteLine("Player");
            Console.WriteLine("====" + player.ToString());
            AbstractDamage fb = new FireballDamage(10, player);
            fb.DoDamage();
            Console.WriteLine("Life after fireball damage 10: " + player.GetLife() + " is alive: " + player.IsAlive());
            AbstractDamage ice = new IceDamage(10, player);
            ice.DoDamage();
            Console.WriteLine("Life after ice damage 10: " + player.GetLife() + " is alive: " + player.IsAlive());
            AbstractDamage light = new LightningDamage(20,player);
            light.DoDamage();
            Console.WriteLine("Life after lightning damage 20: " + player.GetLife() + " is alive: " + player.IsAlive());
            AbstractDamage iceAndFire = new IceAndFireDamage(40,player);
            iceAndFire.DoDamage();
            Console.WriteLine("Life after iceAndFire damage 40: " + player.GetLife() + " is alive: " + player.IsAlive());
            Console.ReadKey();
        }
    }
}
