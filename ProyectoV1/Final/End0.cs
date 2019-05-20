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
    class End0
    {
        public static void Wall(PictureBox pic, Label tit, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new MedLoc(globalVar.locations[2], globalVar.meds[3], 5, 5, globalVar.enemies[0], 150, 30, 1, globalVar.npcs[1]);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(0, 2, 3, 0, 1);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("F0.jpg");
            tit.Text = "FINAL BATTLE";
            des.Text = desc + "You're about to fight Pennywise but his accomplice \nBowers wants to get rid of you. \nYou need a weapon to defend yourself.";
            Left.Visible = false;
            right.Text = "Attack with a weapon";
            right.Visible = true;
            right.Click += (sender, args) =>
            {
                player.attack(wellHouse.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                End1.AtBow(pic, tit, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                End0.Wall(pic, tit, des, right, Left, player);
            };
        }
    }
}
