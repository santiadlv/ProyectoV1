using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class In0
    {
        public static void Empezar(PictureBox pic, Label tit, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("In0.jpg");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            tit.Text = "IT";
            des.Text = "You're in the butchery and your uncle \n asks you to kill Sam the goat. What do you do?";
            right.Text = "Kill Sam";
            Left.Text = "Spare Sam";
            right.Click += (sender, args) =>
            {
                // Coraje
                In1.School(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                In1.School(pic, des, right, Left);
            };

        }
    }
}
