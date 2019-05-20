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
    class Eddie2
    {
        public static void Correr(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Ed2.jpg");
            des.Text = "The leper turns into Pennywise, grabs you and eats you.\n GAME OVER";
            right.Text = "Exit";
            Left.Visible = false;
            right.Visible = true;
            right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolEd();
                //Volver pantalla
            };
        }
        public static void Hide(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location wellHouse = new MedLoc(globalVar.locations[2], globalVar.meds[3], 5, 5, globalVar.enemies[0], 200, 30, 1, globalVar.npcs[1]);
            Inventory.addItem(wellHouse.getItem(), player);
            string desc = Logic.description.describeObj(2, 2, 3, 0, 1);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Ed3.jpg");
            des.Text = "While hiding, you realize Pennywise was \n watching you and is abaout to attack you. What do you do?";
            right.Text = "Use your inhaler";
            Left.Text = "Attack with a weapon";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                player.heal(player, player.ownedMeds[0].getHP());
                Eddie3.In(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                globalVar.courage += 1;
                player.attack(wellHouse.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                Eddie3.At(pic, des, right, Left, player);
            };
        }
    }
}
