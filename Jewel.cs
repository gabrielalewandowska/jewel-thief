using System;
namespace jewel_thief
{
    public abstract class Jewel : ICanBeStolen
    {
        public bool Collectible { get; set; }
        public int Worth { get; set; }
        public int BurnValue { get; set; }

        public Jewel(int worth)
        {
            this.Collectible = true;
            this.Worth = worth;
            this.BurnValue = 0;
        }

        public void Burn(Thief thief)
        {
            thief.Health = thief.Health - this.BurnValue;
        }

    }
}
