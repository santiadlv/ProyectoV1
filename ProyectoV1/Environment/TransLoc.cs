using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;
using ProyectoV1.Interfaces;

namespace ProyectoV1.Environment
{
    public class TransLoc : Location
    {
        Items transport;

        public TransLoc(string name, string transportName, bool quick, float locRisk, string nameNPC):base(name, locRisk, nameNPC)
        {
            transport = new Transportation(transportName, quick);
        }

        public TransLoc(string name, string transportName, bool quick, string enemyName, int enemyHealth, int enemyDamage, float locRisk, string nameNPC):base(name, enemyName, enemyHealth, enemyDamage, locRisk, nameNPC)
        {
            transport = new Transportation(transportName, quick);
        }

        public override Items getItem()
        {
            return transport;
        }
    }
}
