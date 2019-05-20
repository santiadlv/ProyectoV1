using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class In4
    {
        public static void Ben(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("InBen.jpg");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "As you're walking, you see how the bullies chase after \n your friend Ben and subdue him \n to beat him up. What do you do?";
            Left.Visible = true;
            right.Text = "Nothing";
            Left.Text = "Hit them and run";
            right.Click += (sender, args) =>
            {
                In5.nada(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                In5.kick(pic, des, right, Left);
            };
        }
    }
}
