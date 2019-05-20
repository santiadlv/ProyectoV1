using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class In5
    {
        public static void nada(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Incut.png");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "The bullies take and cut you, you lose health. \n As you're walking home, you stumble upon your friends.";
            Left.Visible = false;
            right.Text = "Next scene";
            right.Click += (sender, args) =>
            {
                In6.Club(pic, des, right, Left);
            };
        }

        public static void kick(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Inrun-min.png");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "You start to run away from the bullies alongside Ben. \n What do you do?";
            right.Text = "Hide behind a tree";
            Left.Text = "Keep running";
            right.Click += (sender, args) =>
            {
                In6.kinfe(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                In6.Club(pic, des, right, Left);
            };

        }
    }
}
