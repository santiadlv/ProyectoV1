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
    class Bill0
    {
        public static void Start(PictureBox pic, Label tit, Label des, Button right, Button Left, Characters player)
        {
            player.Name = globalVar.characters[4];
            pic.Image = Image.FromFile("Bill0.jpg");
            tit.Text = "Bill";
            des.Text = "You're in the basement and hear your \n brother's cute laugh. What do you do?";
            right.Visible = true;
            Left.Visible = true;
            right.Text = "Investigate";
            Left.Text = "Nothing";
            right.Click += (sender, args) =>
            {
                //Coraje++
                globalVar.courage += 1;
                Bill1.Georgie(pic, des, right, Left, player);
                playerChoices.addToList("You investigated the basement.");
            };
            Left.Click += (sender, args) =>
            {
                Bill1.Georgie(pic, des, right, Left, player);
                playerChoices.addToList("You did nothing.");
            };
        }
    }
}
