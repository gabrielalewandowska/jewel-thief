using System;
namespace jewel_thief
{
    public class Sapphire : Jewel
    {
        public Sapphire(int worth) : base(worth)
        {
            this.BurnValue = 30;
        }
    }
}
