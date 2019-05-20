using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.Environment;

namespace ProyectoV1.Objects
{
    public class Money : Items
    {
        public int quantity;

        public Money(int quantity):base()
        {
            this.quantity = quantity;
        }

        public override bool canBeSold()
        {
            return false;
        }

        public int getQuantity()
        {
            return quantity;
        }
    }
}
