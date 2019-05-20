using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Exceptions
{
    class ItemNotSellable : Exception
    {
        public ItemNotSellable() : base() { }
        public ItemNotSellable(string message) : base(message) { }
    }
}
