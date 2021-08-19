using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibarary
{
    public class Player : Character
    {
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int life, int maxLife, Race playerRace, Weapon equippedWeapon)
            : base(name, hitChance, block, life, maxLife)
        {
            PlayerRace = playerRace;
            switch (PlayerRace)
            {
                case Race.Human:
                    Block += 40;
                    MaxLife -= 40;
                    Life -= 40;
                    break;

                case Race.Witch:
                    Block += 35;
                    MaxLife -= 30;
                    Life -= 30;
                    break;

                case Race.Demon:
                    Block += 35;
                    MaxLife -= 25;
                    Life -= 25;
                    break;

                case Race.Dwarf:
                    Block += 15;
                    MaxLife -= 20;
                    Life -= 20;
                    break;

                case Race.Cyborg:
                    Block += 50;
                    MaxLife -= 50;
                    Life -= 50;
                    break;

            }
            EquippedWeapon = equippedWeapon;
        }

        public override string ToString()
        {
            return string.Format($"{Name}\nRace: {PlayerRace}\nLife: {Life} of {MaxLife}\nEquipped Weapon:\n{EquippedWeapon}\nHit Chance: {HitChance}%\nBlock Chance: {Block}%");
        }
        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
