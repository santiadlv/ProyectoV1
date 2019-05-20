using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class In2
    {
        public static void Sewer(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("In2.jpg");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "After talking with your friends, you decide to go to the sewers \n to look for Georgie, who might still be alive." +
                "\n You see a girl's abandoned shoe. What do you do?";
            right.Text = "Go deeper in the sewers";
            Left.Text = "Go elsewhere";
            right.Click += (sender, args) =>
            {
                In3.drenaje(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                In4.Ben(pic, des, right, Left);

            };
        }
    }
}
