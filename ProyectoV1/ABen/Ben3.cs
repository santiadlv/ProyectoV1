using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.ABen
{
    class Ben3
    {
        public static void atacar(PictureBox pic, Label des, Button Right, Button Left)
        {
            pic.Image = Image.FromFile("Ben3.jpg");
            des.Text = "You managed to attack the monster without getting hurt.";
            Right.Visible = true;
            Left.Visible = false;
            Right.Text = "Go back";
            Right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                Right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolBen();
                //Volver pantalla
            };
        }

        public static void huir(PictureBox pic, Label des, Button Right, Button Left)
        {
            pic.Image = Image.FromFile("Ben3.jpg");
            des.Text = "You managed to attack the monster without getting hurt.";
            Right.Visible = true;
            Left.Visible = false;
            Right.Text = "Go back";
            Right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                Right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolBen();
                //Volver pantalla
            };
        }
    }
}
