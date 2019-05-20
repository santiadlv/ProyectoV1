using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Interfaces;

namespace ProyectoV1.People
{
    public class NPCs : IDescription
    {
        string name;
        
        public NPCs(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public string objDescription()
        {
            return "You met someone you knew: " + name + ".";
        }
    }
}
