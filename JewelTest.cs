using NUnit.Framework;
using System;
namespace jewel_thief
{
    [TestFixture()]
    public class JewelTest
    {   
        private Thief thief;
        private Ruby ruby;
        private Sapphire sapphire;

        [SetUp]
        public void Init()
        {
            thief = new Thief(3, 0, 1, 2, 1);
            ruby = new Ruby(100);
            sapphire = new Sapphire(120);
        }

        [Test()]
        public void RubyBurns()
        {
            ruby.Burn(thief);
            Assert.AreEqual(-19, thief.Health);
        }

        [Test()]
        public void SapphireBurns()
        {
            sapphire.Burn(thief);
            Assert.AreEqual(-29, thief.Health);
        }
    }
}
