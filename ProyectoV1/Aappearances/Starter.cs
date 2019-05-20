using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoV1.Aappearances
{
    class Starter
    {
        static bool ben = false;
        static bool bill = false;
        static bool bev = false;
        static bool ed = false;
        static bool stan = false;
        static int counter = 0;
        public static void select(Button right, Button left, Button up, Button cent, Button down, PictureBox pic, Label Ti, Label des, Button MVP)
        {
            pic.Image = Image.FromFile("Losers.png");
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            MVP.Visible = false;
            right.Text = "Ben";
            if (ben == true)
            {
                right.Visible = false;
                counter++;
            }
            if (ben == false)
            {
                right.Visible = true;
            }
            if (bill == true)
            {
                left.Visible = false;
                counter++;
            }
            if (bill == false)
            {
                left.Visible = true;
            }
            if (bev == true)
            {
                up.Visible = false;
                counter++;
            }
            if (bev == false)
            {
                up.Visible = true;
            }
            if (ed == true)
            {
                cent.Visible = false;
                counter++;
            }
            if (ed == false)
            {
                cent.Visible = true;
            }
            if (stan == true)
            {
                down.Visible = false;
                counter++;
            }
            if (stan == false)
            {
                down.Visible = true;
            }
            up.Text = "Beverly";
            left.Text = "Bill";
            cent.Text = "Eddie";
            down.Text = "Stanley";


            Ti.Text = "Choose a character:";
            des.Text = "";


        }
        public void BoolBen()
        {
            ben = true;

        }
        public void BoolBill()
        {
            bill = true;

        }
        public void BoolBev()
        {
            bev = true;

        }
        public void BoolEd()
        {
            ed = true;

        }
        public void BoolStan()
        {
            stan = true;

        }

        public static bool End(Button End)
        {
            if (counter >= 1)
            {
                return true;
            }
            else
                return false;
        }
    }
}
