using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Final
{
    class Game_Over
    {
        public static void GO(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("FGO.jpg");
            des.Text = "Pennywise tricked you! It's the end for you and your friends. \n Everybody gets killed by Pennywise. \n GAME OVER";
            right.Visible = true;
            right.Text = "Exit";
            Left.Visible = false;
            right.Click += (sender, args) =>
            {

                //Volver pantalla
            };
        }
    }
}
