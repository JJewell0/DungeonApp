using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibarary
{

    public class LazySkeleton : Monster
    {
        public bool CanTeleport { get; set; }

        public LazySkeleton(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, life, maxLife, minDamage, maxDamage, description)
        {
            CanTeleport = CanTeleport;
            if (CanTeleport)
            {
                Block +=90;
                HitChance += 50;
                Description += "\n*I got a bone to pick with you.";
            }
        }
    }
}

