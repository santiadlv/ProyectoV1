using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Inicio
{
    class In3
    {
        public static void drenaje(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Indren.jpg");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            des.Text = "While walking you stumble upon Pennywise, \n he attacks you and lose health, \n but manage to escape.";
            Left.Visible = false;
            right.Text = "Next scene";
            right.Click += (sender, args) =>
            {
                In4.Ben(pic, des, right, Left);
            };
        }
    }
}
