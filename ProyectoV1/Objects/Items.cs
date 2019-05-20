using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Environment;
using ProyectoV1.Interfaces;

namespace ProyectoV1.Objects
{
    public abstract class Items : ISold, IDescription
    {
        public string name;
        public int price;

        public Items() { }
        
        public Items(string name)
        {
            this.name = name;
        }

        public Items(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract bool canBeSold();

        public string getName()
        {
            return name;
        }

        public int getPrice()
        {
            return price;
        }

        public string objDescription()
        {
            return "You found an item: " + name + ".";
        }
    }
}
