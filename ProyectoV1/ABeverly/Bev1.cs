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

namespace ProyectoV1.ABeverly
{
    class Bev1
    {
        public static void sangre(PictureBox pic, Label des, Button Right, Button Left, Characters player)
        {
            pic.Image = Image.FromFile("Bev2s.jpg");
            des.Text = "As you peek into the sink, a blood explosion \n covers your face. You scream and your dad \n comes in, sees you're worried and asks you" +
                "\n if you're still his little girl. Are you?";
            Right.Visible = true;
            Left.Visible = true;
            Right.Text = "Yes you are";
            Left.Text = "No you're not";
            Right.Click += (sender, args) =>
            {
                Bev2.gopapa(pic, des, Right, Left);
                playerChoices.addToList("You are his little girl.");
            };
            Left.Click += (sender, args) =>
            {
                //Coraje++
                globalVar.courage += 1;
                Bev2.no(pic, des, Right, Left, player);
                playerChoices.addToList("You're not his little girl.");
            };
        }

        public static void papa(PictureBox pic, Label des, Button Right, Button Left, Characters player)
        {
            pic.Image = Image.FromFile("Bev2p.jpg");
            des.Text = "Your dad notices you're scared and hugs you. \n He asks you if you're still his little girl. Are you?";
            Right.Visible = true;
            Left.Visible = true;
            Right.Text = "Yes you are";
            Left.Text = "No you're not";
            Right.Click += (sender, args) =>
            {
                Bev2.gopapa(pic, des, Right, Left);
                playerChoices.addToList("You are his little girl.");

            };
            Left.Click += (sender, args) =>
            {
                //Coraje++
                globalVar.courage += 1;
                Bev2.no(pic, des, Right, Left, player);
                playerChoices.addToList("You're not his little girl.");

            };
        }
    }
}
