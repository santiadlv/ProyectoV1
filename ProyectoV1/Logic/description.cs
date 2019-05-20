using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Logic
{
    public static class description
    {
        public static string describeObj(int playerIndex, int locIndex, int itemIndex, int npcIndex)
        {
            return "You're " + globalVar.characters[playerIndex] + " and you visited " + globalVar.locations[locIndex] + ". While wandering around, you found a " + globalVar.items[itemIndex] + ". Someone you knew was there: it was " + globalVar.npcs[npcIndex] +".";
        }

        public static string describeObj(int playerIndex, int locIndex, int itemIndex, int enemyIndex, int npcIndex)
        {
            return "You're " + globalVar.characters[playerIndex] + " and you visited " + globalVar.locations[locIndex] + ". While wandering around, you found a " + globalVar.items[itemIndex] + ", but also saw " + globalVar.enemies[enemyIndex] + ". Someone you knew was there: it was " + globalVar.npcs[npcIndex] + ".";
        }
    }
}
