using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsTemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTemplateMethod.Tests
{
    [TestClass()]
    public class FireballDamageTests
    {
        private Player player;
        private FireballDamage fireball;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            player.FireResist = 15;
            fireball = new FireballDamage(40, player);

        }
        [TestCleanup()]
        public void Cleanup()
        {
            player = null;
            fireball = null;
        }

        [TestMethod()]
        public void DamageAfterColdTest()
        {
            Assert.AreEqual(40, fireball.DamageAfterCold(40));
        }

        [TestMethod()]
        public void DamageAfterElectricityTest()
        {
            Assert.AreEqual(35, fireball.DamageAfterElectricity(35));
        }

        [TestMethod()]
        public void DamageAfterFireTest()
        {
            Assert.AreEqual(25, fireball.DamageAfterFire(40));
        }
    }
}