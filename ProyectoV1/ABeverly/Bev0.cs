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
    class Bev0
    {
        public static void Start(PictureBox pic, Label tit, Label des, Button right, Button Left, Characters player)
        {
            player.Name = globalVar.characters[3];
            Location bevBathroom = new MonLoc(globalVar.locations[5], 20, 0.25f, globalVar.npcs[5]);
            string desc = Logic.description.describeObj(3, 5, 23, 5);
            Wallet.findMoney((Money)bevBathroom.getItem());
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Beverly.jpg");
            right.Visible = true;
            Left.Visible = true;
            tit.Text = "Beverly";
            des.Text = "You're in your bathroom and you hear voices coming from the sink. What do you do?";
            right.Text = "Investigate the sink";
            Left.Text = "Tell your dad";
            right.Click += (sender, args) =>
            {
                //coraje++
                globalVar.courage += 1;
                Bev1.sangre(pic, des, right, Left, player);
                playerChoices.addToList("You investigated the sink.");
            };
            Left.Click += (sender, args) =>
            {
                Bev1.papa(pic, des, right, Left, player);
                playerChoices.addToList("You told your dad.");
            };
        }
    }
}
