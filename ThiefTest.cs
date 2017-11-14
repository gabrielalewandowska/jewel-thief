using NUnit.Framework;
using System;
namespace jewel_thief
{
    [TestFixture()]
    public class ThiefTest
    {
        private Thief thief;

        [SetUp]
        public void Init()
        {
            thief = new Thief(3, 0, 1, 2, 1);
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
    }
}
