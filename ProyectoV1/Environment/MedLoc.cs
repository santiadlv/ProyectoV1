using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;
using ProyectoV1.Interfaces;
using ProyectoV1.Logic;

namespace ProyectoV1.Environment
{
    public class MedLoc : Location
    {
        Items meds;

        public MedLoc(string name, string medsName, int price, int healthPoints, float locRisk, string nameNPC):base(name,locRisk, nameNPC)
        {
            meds = new Meds(medsName, price, healthPoints);
        }

        public MedLoc(string name, string medsName, int price, int healthPoints, string enemyName, int enemyHealth, int enemyDamage, float locRisk, string nameNPC):base(name, enemyName, enemyHealth, enemyDamage, locRisk, nameNPC)
        {
            meds = new Meds(medsName, price, healthPoints);
        }

        public override Items getItem()
        {
            return meds;
        }
    }
}
