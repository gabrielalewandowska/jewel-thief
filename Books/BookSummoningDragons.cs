using System;
namespace jewel_thief
{
    public class BookSummoningDragons : Book
    {
        public BookSummoningDragons(int value) : base(value)
        {
        }

        public override void Teach(Thief thief)
        {
            thief.CanSummonDragons = true;
            this.WasRead = true;
        }
    }
}
