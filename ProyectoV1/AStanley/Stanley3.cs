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

namespace ProyectoV1.AStanley
{
    class Stanley3
    {
        public static void Stan(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Stan3.jpg");
            des.Text = "You manage to attack the woman and get out alive.";
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
                ap.BoolStan();
                //Volver pantalla
            };
        }

        public static void Run(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            player.takeDamage(player, 10);
            pic.Image = Image.FromFile("Stan3.jpg");
            des.Text = "While trying to escape, the woman bites \n you and you lose health, but are still alive.";
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
                ap.BoolStan();
                //Volver pantalla
            };
        }
    }
}
