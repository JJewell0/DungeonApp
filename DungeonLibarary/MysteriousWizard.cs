using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibarary
{

    public class MysteriousWizard : Monster
    {
        public bool CanTeleport { get; set; }

        public MysteriousWizard(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, life, maxLife, minDamage, maxDamage, description)
        {
            CanTeleport = CanTeleport;
            if (CanTeleport)
            {
                Block += 90;
                HitChance += 50;
                Description += "\nHe stares at you with a mysterious glint in his eye.";
            }
        }
    }
}

