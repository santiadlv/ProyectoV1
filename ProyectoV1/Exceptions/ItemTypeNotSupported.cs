using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Exceptions
{
    class ItemTypeNotSupported : Exception
    {
        public ItemTypeNotSupported() : base() { }
        public ItemTypeNotSupported(string message) : base(message) { }
    }
}
