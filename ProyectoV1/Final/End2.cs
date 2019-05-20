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
    class End2
    {
        public static void Gor(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new WeapLoc(globalVar.locations[2], globalVar.weapons[5], 40, globalVar.enemies[0], 70, 30, 1, globalVar.npcs[2]);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(3, 2, 10, 0, 1);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("FGe.png");
            des.Text = desc + "Pennywise dodges your attack and leaves. \n When you turn around, your realize that Georgie is \n there telling you:" +
                " You've beaten Pennywise, and I never died.\n This is a happy moment for you. What do you do?";
            right.Text = "Attack Georgie";
            Left.Text = "Trust Georgie";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                //Quitar vida IT
                globalVar.courage += 1;

                player.attack(wellHouse.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                End3.ATck(pic, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                Game_Over.GO(pic, des, right, Left);
            };
        }
    }
}
