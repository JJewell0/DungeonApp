using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibarary
{
    public class Combat
    {
        public static void Attack(Character attacker, Character defender)
        {
            int diceRoll = new Random().Next(1, 101);

            System.Threading.Thread.Sleep(35);
            if (diceRoll <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damageDealth = attacker.CalcDamage();
                defender.Life -= damageDealth;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealth} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }
        public static void Battle(Player player, Monster monster)
        {
            Attack(player, monster);
            if (monster.Life > 0)
            {
                Attack(monster, player);
            }
        }
    }
}


