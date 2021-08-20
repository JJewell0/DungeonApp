using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibarary;

namespace DungeonApp
{
    public class Program
    {
        static void Main(string[] args)

        {

            string heroName;
            Race heroRace = Race.Human;
            int killCount = 0;


            Console.Title = "The Dungeon Dweller";
            Console.WriteLine("What is your name?");
            heroName = Console.ReadLine();
            Console.Clear();

            bool raceMenu = true;
            do
            {
                Console.WriteLine("What are you?\n" + "1. Human - fragile yet formidible\n" + "2. Witch -basically superhuman, likes magic-tricks.\n" + "3. Demon - not as deadly as you'd think but can still kick butt.\n" + "4. Dwarf - They say dynamite comes in small packages.\n" + "5. Cyborg - says 'calculated' after every kill.");
                ConsoleKey raceChoice = Console.ReadKey().Key;
                Console.Clear();
                switch (raceChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        heroRace = Race.Human;
                        raceMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        heroRace = Race.Witch;
                        raceMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        heroRace = Race.Demon;
                        raceMenu = false;
                        break;


                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        heroRace = Race.Dwarf;
                        raceMenu = false;
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        heroRace = Race.Cyborg;
                        raceMenu = false;
                        break;


                    default:
                        Console.WriteLine($"{raceChoice} is unheard of! Try again.");
                        break;
                }
            } while (raceMenu);


            Console.WriteLine($"Welcome,{heroName} the {heroRace}!\nReady or not, its adventure time!");
            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("You find yourself in a strange place, its dark.\n");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2500);


            Weapon starterSword = new Weapon("Stick", 1, 1, 1, false);
            Player player = new Player("Local Dweller", 60, 10, 50, 50, Race.Human, starterSword);

            bool exit = false;
            do
            {
                Console.WriteLine(Rooms.GetRoom()); //-----vv so basically wrote this worng, easy fix
                Monster EvilSandwich = new Monster("Evil Sandwich", 30, 4, 10, 10, 1, 4, "A voice yells at you within the darkness -- it approaches... its a sandwich.");

                Monster LazySkeleton = new Monster("Lazy Skeleton", 50, 4, 25, 15, 1, 6, "A skeleton appears in front of you slurping a smoothie.");

                Monster MysteriousWizard = new Monster("Mysterious Wizard", 40, 10, 10, 10, 1, 6, "Watch out! He has glitter in his pockets! You know that won't wash out easy.");

                Monster Entity = new Monster("Entity", 50, 20, 20, 1, 6, 10, "Everything about this thing is unknown.");

                Monster[] monsters =
                {
                    EvilSandwich, EvilSandwich, LazySkeleton, LazySkeleton, LazySkeleton, MysteriousWizard, MysteriousWizard, MysteriousWizard, MysteriousWizard, Entity
                };
                Random rand = new Random();
                int index = rand.Next(monsters.Length);
                Monster monster = monsters[index];
                Console.WriteLine("Watch out! There's a " + monster.Name + "!");

                bool reload = false;
                do
                {
                    Console.WriteLine($"Life remaining: {player.Life} Monsters Killed: {killCount}");
                    Console.WriteLine("What should you do?:\n" +
                        "A)ttack\n" +
                        "F)lee\n" +
                        "V)iew stats\n" +
                        "M)onster Stats");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack goes here..");
                            Combat.Battle(player, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You've killed the " + monster.Name + "!");
                                Console.ResetColor();
                                reload = true;
                                System.Threading.Thread.Sleep(2000);
                                killCount++;
                            }
                            break;

                        case ConsoleKey.F:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You flee!");
                            Console.ResetColor();
                            Console.WriteLine($"The {monster.Name} is petty and attacks as you run away.");

                            Combat.Attack(monster, player);
                            reload = true;
                            break;

                        case ConsoleKey.V:
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You've managed to escape. For now.");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("That isn't an option.");
                            break;
                    }
                    if (player.Life < 1)
                    {
                        Console.WriteLine("You've been slain by a { monster.Name}");
                        exit = true;
                    }

                } while (!reload && !exit);

            } while (!exit);

            Console.WriteLine("GAME OVER!");
        }//end main
    }// end class
}// end namespace


