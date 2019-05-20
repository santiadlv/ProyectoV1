using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoV1;
using WMPLib;
using ProyectoV1.Objects;
using ProyectoV1.Environment;

namespace ProyectoV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> locations = Misc.fileReader.txtToList(Misc.fileReader.listType.Location);
            //Misc.fileReader.Sort(locations);
            //temp.DataSource = locations;

            timer1.Interval = 17000;
            timer1.Start();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = "ITopening.mp4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            timer1.Stop();
            axWindowsMediaPlayer1.Visible = false;
            bttnSkip.Visible = false;
            axWindowsMediaPlayer1.SendToBack();
        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            Form2 PlayForm = new Form2();
            this.Hide();
            PlayForm.Show();
        }

        private void bttnSkip_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.SendToBack();
            bttnSkip.Visible = false;
        }
    }
}
