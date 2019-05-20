using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;
using ProyectoV1.Interfaces;

namespace ProyectoV1.Environment
{
    public class WeapLoc : Location
    {
        Items weapon;

        public WeapLoc(string name, string weaponName, int damagePoints, float locRisk, string nameNPC):base(name, locRisk, nameNPC)
        {
            weapon = new Weapon(weaponName, damagePoints);
        }

        public WeapLoc(string name, string weaponName, int damagePoints, string enemyName, int enemyHealth, int enemyDamage, float locRisk, string nameNPC):base(name, enemyName, enemyHealth, enemyDamage, locRisk, nameNPC)
        {
            weapon = new Weapon(weaponName, damagePoints);
        }

        public override Items getItem()
        {
            return weapon;
        }
    }
}
