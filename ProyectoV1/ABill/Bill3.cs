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

namespace ProyectoV1.ABill
{
    class Bill3
    {
        public static void Atack(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Bill3.jpg");
            des.Text = "You hurt Pennywise and come out unharmed!";
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
                ap.BoolBill();
                //Volver pantalla
            };
        }

        public static void Huir(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            player.takeDamage(player, 10);
            pic.Image = Image.FromFile("Bill3.jpg");
            des.Text = "You managed to escape Pennywise but with some bruises.";
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
                ap.BoolBill();
                //Volver pantalla
            };
        }
    }
}
