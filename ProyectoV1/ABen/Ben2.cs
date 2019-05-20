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
    class Ben2
    {
        public static void salir(PictureBox pic, Label des, Button Right, Button Left, Characters player)
        {
            player.takeDamage(player, 10);
            pic.Image = Image.FromFile("Ben2.1.jpg");
            des.Text = "The Bullies caught you and you lose health. \n End of scene.";
            Right.Text = "Go back";
            Left.Visible = false;
            Right.Visible = true;
            Right.Click += (sender, args) =>
            {
                playerChoices.addToList("The bullies caught you.");
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                Right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolBen();
                //Volver pantalla 
                //Menos salud
            };
        }

        public static void sotano(PictureBox pic, Label des, Button Right, Button Left, Characters player)
        {
            Location library1 = new MedLoc(globalVar.locations[0], globalVar.meds[0], 10, 5, globalVar.enemies[5], 100, 20, 1.5f, globalVar.npcs[6]);
            Inventory.addItem(library1.getItem(), player);
            string desc = Logic.description.describeObj(0, 0, 0, 5, 6);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Ben2.2.jpg");
            des.Text = desc + "You see a headless man's corpse in the basement \n walking towards you. What do you do?";
            Right.Visible = true;
            Left.Visible = true;
            Right.Text = "Run away";
            Left.Text = "Attack";
            Right.Click += (sender, args) =>
            {
                Ben3.huir(pic, des, Right, Left);
                playerChoices.addToList("You ran away.");
            };
            Left.Click += (sender, args) =>
            {
                //Coraje
                globalVar.courage += 1;

                player.attack(library1.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);

                playerChoices.addToList("You attacked the headless man.");

                Ben3.atacar(pic, des, Right, Left);
            };
        }
    }
}
