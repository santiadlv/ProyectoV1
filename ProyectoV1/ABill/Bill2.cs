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
    class Bill2
    {
        public static void Hug(PictureBox pic, Label des, Button right, Button Left)
        {
            pic.Image = Image.FromFile("Bill2.jpg");
            des.Text = "When you hug him, you realize that Georgie was \n Pennywise all along, and he eats you. \n GAME OVER";
            right.Visible = true;
            Left.Visible = false;
            right.Text = "Exit";
            right.Click += (sender, args) =>
            {
                pic.Image = Image.FromFile("FGO.jpg");
                des.Text = "";
                right.Visible = false;
                Left.Visible = false;
                Aappearances.Starter ap = new Aappearances.Starter();
                ap.BoolBill();
                //Volver pantalla 

            };
        }

        public static void Ask(PictureBox pic, Label des, Button right, Button Left, Characters player)
        {
            Location billBasement = new TransLoc(globalVar.locations[4], globalVar.transports[1], true, globalVar.enemies[0], 200, 30, 1, globalVar.npcs[4]);
            Inventory.addItem(billBasement.getItem(), player);
            string desc = Logic.description.describeObj(4, 4, 7, 0, 4);
            playerChoices.addToList(desc);

            pic.Image = Image.FromFile("Bill2.jpg");
            des.Text = desc + "While interrogating Georgie, he \n morphs into Pennywise and tries to attack you. What do you do?";
            right.Text = "Attack with a weapon";
            Left.Text = "Escape";
            right.Visible = true;
            Left.Visible = true;
            right.Click += (sender, args) =>
            {
                //coraje++
                globalVar.courage += 1;
                player.attack(billBasement.getEnemy(), player.ownedWeapons[0]);
                Inventory.removeItem(player.ownedWeapons[0], player);
                playerChoices.addToList("You attacked Pennywise.");
                Bill3.Atack(pic, des, right, Left);
            };
            Left.Click += (sender, args) =>
            {
                Bill3.Huir(pic, des, right, Left, player);
                playerChoices.addToList("You escaped from Pennywise.");
            };
        }
    }
}
