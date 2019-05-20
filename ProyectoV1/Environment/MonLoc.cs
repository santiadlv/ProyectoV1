using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;
using ProyectoV1.Interfaces;

namespace ProyectoV1.Environment
{
    public class MonLoc : Location
    {
        Items money;

        public MonLoc(string name, int moneyQuantity, float locRisk, string nameNPC):base(name, locRisk, nameNPC)
        {
            money = new Money(moneyQuantity);
        }

        public MonLoc(string name, int moneyQuantity, string enemyName, int enemyHealth, int enemyDamage, float locRisk, string nameNPC):base(name, enemyName, enemyHealth, enemyDamage, locRisk, nameNPC)
        {
            money = new Money(moneyQuantity);
        }

        public override Items getItem()
        {
            return money;
        }
    }
}
