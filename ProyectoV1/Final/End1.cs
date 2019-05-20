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
    class End1
    {
        public static void AtBow(PictureBox pic, Label tit, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new WeapLoc(globalVar.locations[2], globalVar.weapons[2], 30, globalVar.enemies[0], 110, 30, 1, globalVar.npcs[1]);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(1, 2, 12, 0, 1);
            playerChoices.addToList(desc);

            // if no tienes arma sera Game Over
            //pic.Image = Image.FromFile(@"\\Mac\Home\Desktop\Media\F1.jpg");
            pic.Image = Image.FromFile("F2.jpg");
            des.Text = desc + "You managed to beat Bowers. \n You keep going down the sewers and stumble upon \n the final boss PENNYWISE!\n Who has kidnapped Beverly! What do you do?";
            right.Text = "Not help and run";
            Left.Text = "Attack him";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Game_Over.GO(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                // Coraje++
                globalVar.courage += 1;

                player.attack(wellHouse.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                End2.Gor(pic, des, right, Left, player);
            };
        }
    }
}
