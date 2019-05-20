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

namespace ProyectoV1.Final
{
    class Ending
    {
        public static void Win(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Winner.jpg");
            des.Text = "You beat Pennywise! \n You saved the children of Derry! \n You won!";
            right.Text = "Exit";
            Left.Visible = false;
            right.Visible = true;

            playerChoices.addToList("YOU WON!");

            right.Click += (sender, args) =>
            {
                MessageBox.Show("YOU WON!");
                //Volver pantalla
            };
        }

        public static void Lose(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("FGoGe.jpg");
            des.Text = "You didn't have enough courage or strength. \n Pennywise has murdered and eaten you. \n You lost.";
            right.Text = "Exit";
            Left.Visible = false;
            right.Visible = true;

            playerChoices.addToList("You lost...");

            right.Click += (sender, args) =>
            {
                MessageBox.Show("PENNYWISE WILL EAT YOU TONIGHT!");
                //Volver pantalla
            };
        }
    }
}
