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
    class Stanley0
    {
        public static void Start(PictureBox pic, Label tit, Label des, Button right, Button Left, Characters player)
        {
            player.Name = globalVar.characters[0];

            pic.Image = Image.FromFile("Stan.jpg");
            tit.Text = "Stanley";
            des.Text = "You're studying the Torah in the Synagogue \n and listen a flute playing in another room. What do you do?";
            right.Text = "Keep studying";
            Left.Text = "Investigate";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Stanley1.Floot(pic, des, right, Left, player);
            };
            Left.Click += (sender, args) =>
            {
                Stanley1.Floot(pic, des, right, Left, player);
            };

        }
    }
}
