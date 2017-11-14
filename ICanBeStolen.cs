using System;
namespace jewel_thief
{
    public interface ICanBeStolen
    {
        bool Collectible { get; set; }
        int Value { get; set; }
    }
}
