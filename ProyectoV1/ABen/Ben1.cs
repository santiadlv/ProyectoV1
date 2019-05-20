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

namespace ProyectoV1.ABen
{
    class Ben1
    {
        public static void Benglobo(PictureBox pic, Label des, Button Right, Button Left, Characters player)
        {
            pic.Image = Image.FromFile("Ben2.jpg");
            des.Text = "You feel a presence behind you, and when you turn you see a balloon \n that is headed to the basement.\n" +
                "What do you do?";
            Right.Visible = true;
            Left.Visible = true;
            Right.Text = "Follow the balloon";
            Left.Text = "Get out of the library";
            Right.Click += (sender, args) =>
            {
                globalVar.courage += 1;
                Ben2.sotano(pic, des, Right, Left, player);
                playerChoices.addToList("You followed the balloon.");
            };
            Left.Click += (sender, args) =>
            {
                Ben2.salir(pic, des, Right, Left, player);
                playerChoices.addToList("You got out of the library.");
            };
        }
    }
}
