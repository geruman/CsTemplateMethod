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
    public class PlayerTests
    {
        private Player player;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            player = null;
        }
        [TestMethod()]
        public void PlayerTest()
        {
            Assert.AreEqual(100, player.GetLife());
        }

        [TestMethod()]
        public void GetLifeTest()
        {
            Assert.AreEqual(100, player.GetLife());
            player.ReceiveDamage(80);
            Assert.AreEqual(20, player.GetLife());
        }

        [TestMethod()]
        public void IsAliveTest()
        {
            Assert.IsTrue(player.IsAlive());
            player.ReceiveDamage(102);
            Assert.IsFalse(player.IsAlive());
        }

        [TestMethod()]
        public void ReceiveDamageTest()
        {
            Assert.AreEqual(100, player.GetLife());
            player.ReceiveDamage(20);
            Assert.AreEqual(80, player.GetLife());
        }
    }
}