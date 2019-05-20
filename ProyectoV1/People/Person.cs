using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;
using ProyectoV1.Interfaces;

namespace ProyectoV1.People
{
    public abstract class Person : IDamageControl, IDescription
    {
        string name;
        int health;

        public Person(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }

        public abstract void attack(Person person, Weapon weapon);
        public abstract string objDescription();
        public abstract void takeDamage(Person person, int damage);
    }
}
