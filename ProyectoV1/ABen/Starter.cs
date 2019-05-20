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

namespace ProyectoV1.ABen
{
    class Starter
    {
        public static void startBen(PictureBox pic, Label tit, Label des, Button Right, Button Left, Characters player)
        {
            player.Name = globalVar.characters[1];
            Location library = new WeapLoc(globalVar.locations[0], globalVar.weapons[8], 15, 0.5f, globalVar.npcs[6]);
            string desc = Logic.description.describeObj(1, 0, 18, 6);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Ben1.jpg");
            tit.Text = "Ben";
            des.Text = desc + "\nYou're in the library reading a history book. What do you do afterwards?";
            Right.Visible = true;
            Left.Visible = true;
            Right.Text = "Steal the book";
            Left.Text = "Keep reading the book";
            Right.Click += (sender, args) =>
            {
                ABen.Ben1.Benglobo(pic, des, Right, Left, player);
                Objects.Inventory.addItem(library.getItem(), player);
                playerChoices.addToList("You stole the book.");
            };
            Left.Click += (sender, args) =>
            {
                ABen.Ben1.Benglobo(pic, des, Right, Left, player);
                playerChoices.addToList("You read the book.");
            };
        }
    }
}
