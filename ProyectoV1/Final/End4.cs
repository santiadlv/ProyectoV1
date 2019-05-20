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
    class End4
    {
        public static void Bill(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new WeapLoc(globalVar.locations[2], globalVar.weapons[4], 35, globalVar.enemies[0], 20, 30, 1, globalVar.npcs[6]);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(5, 2, 14, 0, 1);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("FBill.jpg");
            des.Text = desc + "OH NO! Pennywise has kidnapped Bill! \n Apparently, he'll let you all go if you let \n him take Bill. What do you do?";
            right.Text = "Abandon Bill and save myself";
            Left.Text = "Fight for Bill";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Game_Over.GO(pic, des, right, Left);

            };
            Left.Click += (sender, args) =>
            {
                globalVar.courage += 1;
                player.attack(wellHouse.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                End5.Fight(pic, des, right, Left, player);
            };
        }
    }
}
