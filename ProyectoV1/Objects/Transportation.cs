using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Environment;
using ProyectoV1.People;

namespace ProyectoV1.Objects
{
    public class Transportation : Items
    {
        bool quick;

        public Transportation(string name, bool quick) : base(name)
        {
            this.quick = quick;
        }

        public override bool canBeSold()
        {
            return false;
        }

        public bool getSpeed()
        {
            return quick;
        }
    }
}
