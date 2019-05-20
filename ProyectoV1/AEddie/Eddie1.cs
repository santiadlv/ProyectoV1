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

namespace ProyectoV1.AEddie
{
    class Eddie1
    {
        public static void See(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new MonLoc(globalVar.locations[2], 30, globalVar.enemies[4], 20, 10, 1, globalVar.npcs[1]);
            Wallet.findMoney((Money)wellHouse.getItem());
            string desc = Logic.description.describeObj(2, 2, 21, 4, 1);
            playerChoices.addToList(desc);
            player.takeDamage(player, wellHouse.getEnemy().getDamage());

            pic.Image = Image.FromFile("Ed1.jpg");
            des.Text = desc + "A leper comes from behind you and attacks you. What do you do?";
            right.Text = "Hide";
            Left.Text = "Run";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Eddie2.Hide(pic, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                Eddie2.Correr(pic, des, right, Left);
            };
        }

        public static void Walk(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            pic.Image = Image.FromFile("Ed1.jpg");
            des.Text = "You see a distant leper getting closer to you. What do you do?";
            right.Text = "Hide";
            Left.Text = "Run";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Eddie2.Hide(pic, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                Eddie2.Correr(pic, des, right, Left);
            };
        }
    }
}
