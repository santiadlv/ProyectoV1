using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProyectoV1.Objects;
using ProyectoV1.People;
using ProyectoV1.Environment;
using ProyectoV1.Logic;

namespace ProyectoV1.AEddie
{
    class Eddie3
    {
        public static void In(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Edin.jpg");
            des.Text = "Pennywise lets you escape and you make it home safely.";
            right.Text = "Go back";
            Left.Visible = false;
            right.Visible = true;
            right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolEd();
                //Volver pantalla
            };
        }
        public static void At(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            player.takeDamage(player, 20);
            pic.Image = Image.FromFile("Edit.jpg");
            des.Text = "You attack Pennywise, but he strikes \n back and lose health. Still, you manage to escape.";
            right.Text = "Go back";
            right.Visible = true;
            Left.Visible = false;
            right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolEd();
                //Volver pantalla
            };
        }
    }
}
