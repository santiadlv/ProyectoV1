using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV1.Logic
{
    public static class riskChecker
    {
        public static void checkRisk(Form x)
        {
            if (globalVar.riskLevel >= 5 && globalVar.riskLevel < 10)
            {
                MessageBox.Show("WARNING: You are starting to feel considerably scared. Take it easy or use some meds before it's too late.");
            }
            else if (globalVar.riskLevel >= 10)
            {
                MessageBox.Show("You're now scared to death and can't continue. We'd be sorry for you, but we warned you... GAME OVER");
                x.Close();
            }
            else { }
        }
    }
}
