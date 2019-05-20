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
    class Stanley2
    {
        public static void Dan(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location synagogue = new TransLoc(globalVar.locations[9], globalVar.transports[3], true, globalVar.enemies[2], 50, 10, 0.5f, globalVar.npcs[3]);
            string desc = Logic.description.describeObj(0, 9, 10, 2, 3);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Stan2.jpg");
            des.Text = "Behind you, you notice the lady in the painting \n is alive and wants to eat you. What do you do?";
            right.Text = "Escape";
            Left.Text = "Attack with a weapon";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Stanley3.Run(pic, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                globalVar.courage += 1;
                player.attack(synagogue.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                Stanley3.Stan(pic, des, right, Left);
            };
        }
    }
}
