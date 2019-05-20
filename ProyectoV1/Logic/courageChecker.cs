using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.People;
using ProyectoV1.Final;
using System.Windows.Forms;

namespace ProyectoV1.Logic
{
    public static class courageChecker
    {
        public static void checkCourage(PictureBox pic, Label des, Button right, Button left)
        {
            if (globalVar.courage >= 1)
            {
                Ending.Win(pic, des, right, left);
            }
            else
            {
                Ending.Lose(pic, des, right, left);
            }
        }
    }
}
