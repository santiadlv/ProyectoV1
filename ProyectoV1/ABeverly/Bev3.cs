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

namespace ProyectoV1.ABeverly
{
    class Bev3
    {
        public static void atck(PictureBox pic, Label des, Button Right, Button Left)
        {
            pic.Image = Image.FromFile("Bev3a.png");
            des.Text = "You attack and kill you dad, now everything's going to be alright.";
            Left.Visible = false;
            Right.Visible = true;
            Right.Text = "Go back";
            Right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                Right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolBev();

                //Volver pantalla 

            };
        }

        public static void huir(PictureBox pic, Label des, Button Right, Button Left, Characters player)
        {
            player.takeDamage(player, 10);
            pic.Image = Image.FromFile("Bev3noa.png");
            des.Text = "Your dad catches up and mildly hurts you. \n Where will you run to?";
            Right.Visible = true;
            Left.Visible = true;
            Right.Text = "Run to your room";
            Left.Text = "Run to the street";
            Right.Click += (sender, args) =>
            {
                Bev4.Cuarto(pic, des, Right, Left);
                playerChoices.addToList("You ran to your room.");
            };
            Left.Click += (sender, args) =>
            {
                Bev4.Calle(pic, des, Right, Left);
                playerChoices.addToList("You ran outside.");
            };
        }
    }
}
