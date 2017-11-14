using System;
namespace jewel_thief
{
    public abstract class Jewel : ICanBeStolen
    {
        public bool Collectible { get; set; }
        public int Worth { get; set; }

        private Jewel(int worth)
        {
            this.Collectible = true;
            this.Worth = worth;
        }

    }
}
