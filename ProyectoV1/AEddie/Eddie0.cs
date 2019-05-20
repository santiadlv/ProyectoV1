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
    class Eddie0
    {
        public static void Start(PictureBox pic, Label tit, Label des, Button right, Button Left, Characters player)
        {
            player.Name = globalVar.characters[2];

            Location wellHouse = new WeapLoc(globalVar.locations[2], globalVar.weapons[1], 20, 0.1f, globalVar.npcs[1]);
            wellHouse.setRisk(wellHouse);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(2, 2, 11, 1);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Ed0.jpg");
            tit.Text = "Eddie";
            des.Text = desc + "While walking down the street, you feel a presence in the house \n next to you. What do you do?";
            right.Text = "Observe the house";
            Left.Text = "Keep walking";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                Eddie1.See(pic, des, right, Left, player);
                playerChoices.addToList("You observed the house.");
            };
            Left.Click += (sender, args) =>
            {
                Eddie1.Walk(pic, des, right, Left, player);
            };
        }
    }
}
