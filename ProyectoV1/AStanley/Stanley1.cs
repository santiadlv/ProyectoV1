using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProyectoV1.Objects;
using ProyectoV1.People;
using ProyectoV1.Environment;
using ProyectoV1.Logic;

namespace ProyectoV1.AStanley
{
    class Stanley1
    {
        public static void Floot(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location synagogue = new WeapLoc(globalVar.locations[9], globalVar.weapons[10], 20, 0.5f, globalVar.npcs[3]);
            string desc = Logic.description.describeObj(0, 9, 20, 3);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Stan1.jpg");
            des.Text = desc + "\nYou walk to the other room and see a painting and a flute in the floor. What do you do?";
            right.Text = "Take the flute";
            Left.Text = "Take the painting";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Inventory.addItem(synagogue.getItem(), player);
                Stanley2.Dan(pic, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                Stanley2.Dan(pic, des, right, Left, player);
            };
        }
    }
}
