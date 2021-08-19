using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibarary
{
    public class Rooms
    {
        public static string GetRoom()
        {
            string[] rooms =
            {
                "Light fills your vision as you walk through a strange door. You reach the other side and you've found yourself in the back of a large tent full of human collectables. You hear someone talking near the entrance.",
                "You enter a small room and your steps echo. Looking about, you're uncertain why, but then a wall vanishes and reveals an enormous chamber. The wall was an illusion and whoever cast it must be nearby!",
                "You find yourself in an old run-down kitchen, the wallpaper is degrading, frayed wires hang from the ceiling, its eerily quiet -- you get the feeling you're being watched.",
                "This small bare chamber holds nothing but a large ironbound chest, which is big enough for a man to fit in and bears a heavy iron lock. The floor has a layer of undisturbed dust upon it.",
                "You open the door and before you is a dragon's hoard of treasure. Coins cover every inch of the room, and jeweled objects of precious metal jut up from the money like glittering islands in a sea of gold.",
                "A glow escapes this room through its open doorways. The masonry between every stone emanates an unnatural orange radiance. Glancing quickly about the room, you note that each stone bears the carving of someone's name..",
                "Fire crackles and pops in a small cooking fire set in the center of the room. The smoke from a burning rat on a spit curls up through a hole in the ceiling. Around the fire lie several fur blankets and a bag. It looks like someone camped here until not long ago, but then left in a hurry.",
                "A 30-foot-tall demonic idol dominates this room of black stone. The potbellied statue is made of red stone, and its grinning face holds what looks to be two large rubies in place of eyes. A fire burns merrily in a wide brazier the idol holds in its lap.",
                "You open the door and a gout of flame rushes at your face. A wave of heat strikes you at the same time and light fills the hall. The room beyond the door is ablaze! An inferno engulfs the place, clinging to bare rock and burning without fuel.",
                "The scent of earthy decay assaults your nose upon peering through the open door to this room. Smashed bookcases and their sundered contents litter the floor. Paper rots in mold-spotted heaps, and shattered wood grows white fungus.",
                "A crack in the ceiling above the middle of the north wall allows a trickle of water to flow down to the floor. The water pools near the base of the wall, and a rivulet runs along the wall an out into the hall. The water smells fresh.",
                "Three low, oblong piles of rubble lie near the center of this small room. Each has a weapon jutting upright from one end -- a longsword, a spear, and a quarterstaff. The piles resemble cairns used to bury dead adventurers.",
                "A stone throne stands on a foot-high circular dais in the center of this cold chamber. The throne and dais bear the simple adornments of patterns of crossed lines -- a pattern also employed around each door to the room.",
            };
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            return rooms[index];
        }
    }
}
