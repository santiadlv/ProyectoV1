using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Interfaces;
using ProyectoV1.Environment;
using ProyectoV1.Logic;

namespace ProyectoV1.Objects
{
    public class Meds : Items
    {
        int healthPoints;

        public Meds(string name, int price, int healthPoints):base(name,price)
        {
            this.healthPoints = healthPoints;
        }

        public override bool canBeSold()
        {
            return true;
        }

        public int getHP()
        {
            return healthPoints;
        }
    }
}
