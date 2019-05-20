using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Interfaces;
using ProyectoV1.Logic;
using ProyectoV1.Objects;
using ProyectoV1.People;

namespace ProyectoV1.Environment
{
    public abstract class Location :  IDescription, IRiskLevel
    {
        string name;
        Enemies enemy;
        NPCs npcName;
        float locRisk;

        public Location(string name, float locRisk, string nameNPC)
        {
            this.name = name;
            this.locRisk = locRisk;
            npcName = new NPCs(nameNPC);
        }

        public Location(string name, string enemyName, int enemyHealth, int enemyDamage, float locRisk, string nameNPC)
        {
            this.name = name;
            enemy = new Enemies(enemyName, enemyHealth, enemyDamage);
            this.locRisk = locRisk;
            npcName = new NPCs(nameNPC);
        }

        public abstract Items getItem();

        public void setRisk(Location loc)
        {
            globalVar.riskLevel += loc.locRisk;
        }

        public Enemies getEnemy()
        {
            return enemy;
        }

        public string objDescription()
        {
            return "You visited a location: " + name + ".";
        }
    }
}
