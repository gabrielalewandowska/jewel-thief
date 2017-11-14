using System;
using System.Collections.Generic;
namespace jewel_thief
{
    public class Thief
    {
        public int Luck { get; set; }
        public int SocialSkills { get; set; }
        public int Health { get; set; }
        public int Agility { get; set; }
        public int Strength { get; set; }
        public List<ICanBeStolen> Sack {get; set;}

        public Thief(int luck, int socialSkills, int health, int agility, int strength)
        {
            this.Luck = luck;
            this.SocialSkills = socialSkills;
            this.Health = health;
            this.Agility = agility;
            this.Strength = strength;
            this.Sack = new List<ICanBeStolen>();
        } 


    }
}
