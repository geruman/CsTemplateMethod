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
    public class LightningDamageTests
    {
        private Player player;
        private AbstractDamage lightning;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            lightning = new LightningDamage(50, player);
            player.FireResist = 4;
            player.ColdResist = 10;
            player.ElectricityResist = 15;
        }
        [TestCleanup()]
        public void Cleanupo()
        {
            player = null;
            lightning = null;
        }
        [TestMethod()]
        public void LightningDamageTest()
        {
            lightning.DoDamage();
            Assert.AreEqual(65, player.GetLife());
        }

        [TestMethod()]
        public void DamageAfterColdTest()
        {
            Assert.AreEqual(50, lightning.DamageAfterCold(50));
        }

        [TestMethod()]
        public void DamageAfterElectricityTest()
        {
            Assert.AreEqual(35, lightning.DamageAfterElectricity(50));
        }

        [TestMethod()]
        public void DamageAfterFireTest()
        {
            Assert.AreEqual(40, lightning.DamageAfterFire(40));
        }
    }
}