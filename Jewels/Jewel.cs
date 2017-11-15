using System;
namespace jewel_thief
{
    public abstract class Jewel : ICanBeStolen
    {
        public bool Collectible { get; set; }
        public int Value { get; set; }
        public int BurnValue { get; set; }

        public Jewel(int value)
        {
            this.Collectible = true;
            this.Value = value;
            this.BurnValue = 0;
        }

        public void Burn(Thief thief)
        {
            thief.Health = thief.Health - this.BurnValue;
        }

    }
}
