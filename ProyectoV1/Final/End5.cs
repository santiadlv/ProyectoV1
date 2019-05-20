using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProyectoV1.Logic;
using ProyectoV1.Objects;
using ProyectoV1.People;
using ProyectoV1.Environment;

namespace ProyectoV1.Final
{
    class End5
    {
        public static void Fight(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new WeapLoc(globalVar.locations[2], globalVar.weapons[7], 35, globalVar.enemies[0], 5, 30, 1, globalVar.npcs[6]);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(6, 2, 17, 0, 3);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Lose.jpg");
            des.Text = desc + "The moment has come, you must fight Pennywise. \n Do you have the courage and strength it takes to beat him?";
            right.Text = "Attack one last time";


            right.Visible = true;
            Left.Visible = false; ;
            right.Click += (sender, args) =>
            {
                // if coraje y fuerza suficiente ending winner
                // else ending lose 
                courageChecker.checkCourage(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                End5.Fight(pic, des, right, Left, player);
            };
        }
    }
}
