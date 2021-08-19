using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibarary
{

    public class Entity : Monster
    {
        public bool CanTeleport { get; set; }

        public Entity(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, life, maxLife, minDamage, maxDamage, description)
        {
            CanTeleport = CanTeleport;
            if (CanTeleport)
            {
                Block += 95;
                HitChance += 80;
                Description += "/n @@@@@@@@";
            }
        }
    }
}
