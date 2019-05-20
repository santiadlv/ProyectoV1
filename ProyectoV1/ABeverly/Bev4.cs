using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.ABeverly
{
    class Bev4
    {
        public static void Cuarto(PictureBox pic, Label des, Button Right, Button Left)
        {
            pic.Image = Image.FromFile("BevIT.png");
            des.Text = "When you enter your room, you realize that \n Pennywise was waiting for you.\n GAME OVER";
            Left.Visible = false;
            Right.Visible = true;
            Right.Text = "Exit";
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

        public static void Calle(PictureBox pic, Label des, Button Right, Button Left)
        {
            pic.Image = Image.FromFile("BevSafe.jpg");
            des.Text = "You hide on the street and now are safe.\n Everything's going to be alright.";
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
    }
}
