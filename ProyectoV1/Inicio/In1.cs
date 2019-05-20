using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class In1
    {
        public static void School(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("In1.jpg");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "Back in school you're with your friends \n and after classes the bullies hit your \n friend Stanley. What do you do?";
            right.Text = "Nothing";
            Left.Text = "Scream 'Assholes!'";
            right.Click += (sender, args) =>
            {
                In2.Sewer(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                // Coraje perder salud
                In2.Sewer(pic, des, right, Left);
            };
        }
    }
}
