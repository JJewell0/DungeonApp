using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibarary
{

    public class EvilSandwich : Monster
    {
        public bool CanTeleport { get; set; }

        public EvilSandwich(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, life, maxLife, minDamage, maxDamage, description)
        {
            CanTeleport = CanTeleport;
            if (CanTeleport)
            {
                Block += 10;
                HitChance += 10;
                Description += "\nDid someone order a knuckle sammich?";
            }
        }
    }
}

