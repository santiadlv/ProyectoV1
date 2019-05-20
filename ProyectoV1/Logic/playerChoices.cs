using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Logic
{
    public static class playerChoices
    {
        public static List<string> choices = new List<string>();

        public static void addToList(string description)
        {
            choices.Add(description);
        }
    }
}
