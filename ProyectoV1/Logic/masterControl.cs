using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;
using ProyectoV1.People;
using ProyectoV1.Environment;

namespace ProyectoV1.Logic
{
    public static class masterControl
    {
        public static void initGame()
        {
            globalVar GV = new globalVar();
            fileManager.initLists();
            //fileManager.Sort(globalVar.characters);
            //fileManager.Sort(globalVar.enemies);
            //fileManager.Sort(globalVar.items);
            //fileManager.Sort(globalVar.locations);
            //fileManager.Sort(globalVar.meds);
            //fileManager.Sort(globalVar.npcs);
            //fileManager.Sort(globalVar.transports);
            //fileManager.Sort(globalVar.weapons);
        }
    }
}
