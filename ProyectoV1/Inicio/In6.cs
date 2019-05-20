using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class In6
    {
        public static void kinfe(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Inbull.jpg");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "The bullies find you and keep cutting you. \n You bled to death. \n GAME OVER";
            Left.Visible = false;
            right.Text = "Exit";
        }

        public static void Club(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Inclub.jpg");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "You find your friends and they take you to the drug store \n so you can buy medicine and get healthy again. What do you do?";
            Left.Visible = true;
            right.Text = "Buy supplies";
            Left.Text = "Don't buy supplies";
            right.Click += (sender, args) =>
            {
                Next.next(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                Next.next(pic, des, right, Left);
            };
        }
    }
}
