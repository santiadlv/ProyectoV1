using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Interfaces;
using ProyectoV1.Objects;
using ProyectoV1.Logic;

namespace ProyectoV1.People
{
    public class Characters : Person
    {
        public List<Meds> ownedMeds;
        public List<Weapon> ownedWeapons;
        Weapon fist = new Weapon("Fist", 5);
        Weapon kicks = new Weapon("Kicks", 10);
        Weapon knuckles = new Weapon("Knuckles", 8);
        Weapon spit = new Weapon("Spit", 2);
        Weapon uppercut = new Weapon("Uppercut", 5);
        public List<Transportation> ownedTransports;

        public Characters(string name, int health) : base(name, health)
        {
            ownedMeds = new List<Meds>();
            ownedWeapons = new List<Weapon>();
            ownedTransports = new List<Transportation>();
            ownedWeapons.Add(fist);
            ownedWeapons.Add(kicks);
            ownedWeapons.Add(knuckles);
            ownedWeapons.Add(spit);
            ownedWeapons.Add(uppercut);
        }
        
        public override void attack(Person person, Weapon weapon)
        {
            person.takeDamage(person, weapon.getDP());
        }

        public override void takeDamage(Person person, int damage)
        {
            person.Health -= damage;
        }

        public void heal(Person person, int healthPoints)
        {
            person.Health += healthPoints;
        }

        public override string objDescription()
        {
            return "You changed characters and now are: " + Name + ".";
        }
    }
}
