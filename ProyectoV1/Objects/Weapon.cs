using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Environment;

namespace ProyectoV1.Objects
{
    public class Weapon : Items
    {
        int damagePoints;
        
        public Weapon(string name, int damagePoints):base(name)
        {
            this.damagePoints = damagePoints;
        }

        public override bool canBeSold()
        {
            return true;
        }

        public int getDP()
        {
            return damagePoints;
        }
    }
}
