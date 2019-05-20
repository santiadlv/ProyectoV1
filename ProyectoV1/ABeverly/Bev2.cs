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
    class Bev2
    {
        public static void gopapa(PictureBox pic, Label des, Button Right, Button Left)
        {
            pic.Image = Image.FromFile("Bev2go.jpg");
            des.Text = "Your dad takes you to another room and you lose consciousness.\n No one ever knows anything about you. \n GAME OVER";
            Left.Visible = false;
            Right.Visible = true;
            Right.Text = "Exit";
            Right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                Right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolBev();
                //Volver pantalla 

            };
        }

        public static void no(PictureBox pic, Label des, Button Right, Button Left, Characters player)
        {
            Location bevHouse = new WeapLoc(globalVar.locations[5], globalVar.weapons[9], 50, globalVar.enemies[6], 50, 10, 0.5f, globalVar.npcs[5]);
            Inventory.addItem(bevHouse.getItem(), player);
            string desc = Logic.description.describeObj(3, 5, 19, 6, 5);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Bev3atc.png");
            des.Text = desc + "He tries to slam you into the ground. What do you do?";
            Right.Visible = true;
            Left.Visible = true;
            Right.Text = "Attack with a weapon";
            Left.Text = "Escape";
            Right.Click += (sender, args) =>
            {
                globalVar.courage += 1;
                player.attack(bevHouse.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                playerChoices.addToList("You attacked daddy.");
                Bev3.atck(pic, des, Right, Left);
            };
            Left.Click += (sender, args) =>
            {
                Bev3.huir(pic, des, Right, Left, player);
                playerChoices.addToList("You escaped from daddy.");
            };

        }
    }
}
