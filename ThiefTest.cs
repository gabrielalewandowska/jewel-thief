using NUnit.Framework;
using System;
namespace jewel_thief
{
    [TestFixture()]
    public class ThiefTest
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
        public void ThiefHasLuck()
        {
            Assert.AreEqual(3, thief.Luck);
        }

        [Test()]
        public void CanSetSocialSkills()
        {
            thief.SocialSkills = 3;
            Assert.AreEqual(3, thief.SocialSkills);
        }

        [Test()]
        public void SackStartsEmpty()
        {
            Assert.AreEqual(0, thief.Sack.Count);
        }

        [Test()]
        public void ThiefCanSteal()
        {
            thief.Steal(ruby);
            thief.Steal(sapphire);
            Assert.AreEqual(2, thief.Sack.Count);
        }

        [Test()]
        public void ThiefCanEvaluateSack()
        {
            thief.Steal(ruby);
            thief.Steal(sapphire);
            Assert.AreEqual(220, thief.EvaluateSack());
        }
    }
}
