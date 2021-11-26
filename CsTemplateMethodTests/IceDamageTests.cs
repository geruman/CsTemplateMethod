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
    public class IceDamageTests
    {
        private Player player;
        private AbstractDamage ice;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            ice = new IceDamage(25, player);
        }
        [TestCleanup()]
        public void Cleanup()
        {
            player = null;
            ice = null;
        }
        [TestMethod()]
        public void IceDamageTest()
        {
            player.ColdResist = 5;
            ice.DoDamage();
            Assert.AreEqual(80, player.GetLife());
        }

        [TestMethod()]
        public void DamageAfterColdTest()
        {
            player.ColdResist = 5;
            Assert.AreEqual(20, ice.DamageAfterCold(25));
        }

        [TestMethod()]
        public void DamageAfterElectricityTest()
        {
            player.ElectricityResist = 5;
            Assert.AreEqual(15, ice.DamageAfterElectricity(15));
        }

        [TestMethod()]
        public void DamageAfterFireTest()
        {
            player.FireResist = 20;
            Assert.AreEqual(100, ice.DamageAfterElectricity(100));
        }
    }
}