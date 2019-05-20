using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Objects;

namespace ProyectoV1.People
{
    public class Enemies : Person
    {
        int damage;

        public Enemies(string name, int health, int damage) : base(name, health)
        {
            this.damage = damage;
        }

        public override void attack(Person person, Weapon weapon) { }
        public override void takeDamage(Person person, int damage) { }

        public int getDamage()
        {
            return damage;
        }

        public override string objDescription()
        {
            return "You met an enemy: " + Name + ".";  
        }
    }
}
