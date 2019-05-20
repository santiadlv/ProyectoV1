using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoV1.Logic
{
    public static class fileManager
    {
        public enum listType { Location, Character, Enemy, Medicine, Weapon, Transport, NPCs, Items };

        public static List<string> txtToList(listType x)
        {
            List<string> empty = new List<string>();
            switch (x)
            {
                case listType.Location:
                    return File.ReadAllLines("locations.txt").ToList();

                case listType.Enemy:
                    return File.ReadAllLines("enemies.txt").ToList();

                case listType.Medicine:
                    return File.ReadAllLines("meds.txt").ToList();

                case listType.Character:
                    return File.ReadAllLines("players.txt").ToList();

                case listType.Transport:
                    return File.ReadAllLines("transport.txt").ToList();

                case listType.Weapon:
                    return File.ReadAllLines("weapons.txt").ToList();

                case listType.NPCs:
                    return File.ReadLines("npcs.txt").ToList();

                case listType.Items:
                    return File.ReadAllLines("items.txt").ToList();

                default:
                    return empty;
            }
        }

        public static void initLists()
        {
            globalVar.locations = txtToList(listType.Location);
            globalVar.enemies = txtToList(listType.Enemy);
            globalVar.meds = txtToList(listType.Medicine);
            globalVar.characters = txtToList(listType.Character);
            globalVar.transports = txtToList(listType.Transport);
            globalVar.weapons = txtToList(listType.Weapon);
            globalVar.npcs = txtToList(listType.NPCs);
            globalVar.items = txtToList(listType.Items);
        }

        public static void listToTxt()
        {
            //TextWriter textWriter = new StreamWriter("PlayerChoices.txt");

            System.IO.File.WriteAllLines("PlayerPath.txt", playerChoices.choices);
        }

        public static void Sort<T>(List<T> array) where T : IComparable
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
