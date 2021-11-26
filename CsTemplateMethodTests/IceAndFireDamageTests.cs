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
    public class IceAndFireDamageTests
    {
        private Player player;
        private AbstractDamage iceAndFire;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            player.ColdResist = 5;
            player.FireResist = 10;
            player.ElectricityResist = 16;
            iceAndFire = new IceAndFireDamage(50, player);
        }
        [TestMethod()]
        public void IceAndFireDamageTest()
        {
            iceAndFire.DoDamage();
            Assert.AreEqual(65, player.GetLife());
        }

        [TestMethod()]
        public void DamageAfterColdTest()
        {
            Assert.AreEqual(10, iceAndFire.DamageAfterCold(15));
        }

        [TestMethod()]
        public void DamageAfterElectricityTest()
        {
            Assert.AreEqual(50, iceAndFire.DamageAfterElectricity(50));
        }

        [TestMethod()]
        public void DamageAfterFireTest()
        {
            Assert.AreEqual(40, iceAndFire.DamageAfterFire(50));
        }
    }
}