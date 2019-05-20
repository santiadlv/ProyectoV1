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

namespace ProyectoV1.Final
{
    class End3
    {
        public static void ATck(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new WeapLoc(globalVar.locations[2], globalVar.weapons[6], 35, globalVar.enemies[0], 40, 30, 1, globalVar.npcs[6]);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(4, 2, 15, 0, 6);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("FAt.jpg");
            des.Text = desc + "You're lucky! Georgie was Pennywise all along. \n You attack and hurt him, and now \n" +
                "is when the final battle begins. \n What do you do?";

            right.Text = "Attack with weapon";
            Left.Text = "Risk it all";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                //Quitar vida IT
                player.attack(wellHouse.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                End4.Bill(pic, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                // Perder salud
                player.takeDamage(player, 20);
                End4.Bill(pic, des, right, Left, player);
            };
        }
    }
}
