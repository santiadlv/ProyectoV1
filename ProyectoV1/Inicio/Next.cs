using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class Next
    {
        public static void next(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Segunda.jpg");
            des.Text = "You've completed the first stage of the game. \n Now comes the fun part.";
            right.Visible = false;
            Left.Visible = false;

            Left.Visible = false;
            right.Visible = true;
            right.Text = "Go back";
            right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                right.Visible = false;
                Left.Visible = false;

                //Volver pantalla 

            };
        }
    }
}
