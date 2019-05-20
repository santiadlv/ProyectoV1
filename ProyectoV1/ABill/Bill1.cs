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
    class Bill1
    {
        public static void Georgie(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            pic.Image = Image.FromFile("Bill1.jpg");
            des.Text = "You see your brother Georgie, who \n had vanished and whom you'd missed \n a lot, and tells you he missed you too. What do you do?";
            right.Text = "Hug him";
            Left.Text = "Interrogate him";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Bill2.Hug(pic, des, right, Left);
                playerChoices.addToList("You hugged him.");
            };
            Left.Click += (sender, args) =>
            {
                Bill2.Ask(pic, des, right, Left, player);
                playerChoices.addToList("You interrogated him.");
            };
        }
    }
}
