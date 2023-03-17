using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior_Fight
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxAttack { get; set; }
        public int MaxBlock { get; set; }

        Random rnd = new Random();
        public Warrior(string name, int health, int maxAttack, int maxBlock)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
        }

        public int GetAttack()
        {
            return rnd.Next(1, MaxAttack);
        }

        public int GetBlock()
        {
            return rnd.Next(1, MaxBlock);
        }
    }
}
