using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;

namespace ProyectoV1.Logic
{
    public class globalVar
    {
        public static List<string> locations;
        public static List<string> enemies;
        public static List<string> meds;
        public static List<string> characters;
        public static List<string> transports;
        public static List<string> weapons;
        public static List<string> npcs;
        public static List<string> items;

        public static float riskLevel;
        public static byte courage;

        public globalVar()
        {
            riskLevel = 0;
            courage = 0;
        }
    }
}
