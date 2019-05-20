using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;
using ProyectoV1.People;

namespace ProyectoV1.Interfaces
{
    interface IDamageControl
    {
        void takeDamage(Person person, int damage);
        void attack(Person person, Weapon weapon);
    }
}
