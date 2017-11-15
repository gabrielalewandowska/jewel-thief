using NUnit.Framework;
using System;
namespace jewel_thief.Tests
{
    [TestFixture()]
    public class BookTest
    {
        private Thief thief;
        private BookSummoningDragons bookDragons;

        [SetUp()]
        public void Init()
        {
            thief = new Thief(3, 0, 1, 2, 1);
            bookDragons = new BookSummoningDragons(200);
        }

        [Test()]
        public void TestRuns()
        {
            Assert.AreEqual(true, true);
        }

        [Test()]
        public void BookCanTeach()
        {
            bookDragons.Teach(thief);
            Assert.AreEqual(true, thief.CanSummonDragons);
        }

        [Test()]
        public void BookHasValue()
        {
            Assert.AreEqual(200, bookDragons.Value);
        }
     
    }
}
