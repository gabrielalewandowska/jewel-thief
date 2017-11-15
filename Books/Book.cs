using System;
namespace jewel_thief
{
    public abstract class Book : ICanBeStolen
    {
        public bool Collectible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool WasRead;

        public Book(int value)
        {
            this.Value = value;
            this.WasRead = false;
        }

        public abstract void Teach(Thief thief);
      
            
    }
}
