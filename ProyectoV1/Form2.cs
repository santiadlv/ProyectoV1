using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoV1.Aappearances;
using ProyectoV1.Logic;
using ProyectoV1.Objects;
using ProyectoV1.People;

namespace ProyectoV1
{
    public partial class Form2 : Form
    {
        public Characters player;

        public Form2()
        {
            player = new Characters("temp", 100);
            masterControl.initGame();
            InitializeComponent();
            //IniciarJuego();
            Start();
            Aappearances.Starter.End(bttnEnd);
        }

        public Characters getCharacters()
        {
            return player;
        }
        
        private void IniciarJuego()
        {
            Predeterminado();
            Inicio.In0.Empezar(picBox, lblTitle, lbl, bttnRight, bttnLeft);
        }

        public void Start()
        {
            Aappearances.Starter.select(bttnBen, bttnBill, bttnUp, bttnCenter, bttnDown, picBox, lblTitle, lbl, bttnMVP);
            if (Aappearances.Starter.End(bttnEnd) == false)
            {
                bttnEnd.Visible = false;
            }
            else if (Starter.End(bttnEnd) == true)
            {
                bttnEnd.Visible = true;
            }
        }

        public void Emvipi()
        {
            bttnMVP.Visible = true;
        }

        private void Predeterminado()
        {

            bttnCenter.Visible = false;
            bttnDown.Visible = false;
            bttnUp.Visible = false;
            bttnBill.Visible = false;
            bttnBen.Visible = false;
            bttnEnd.Visible = false;
            bttnMVP.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bttnUp_Click_1(object sender, EventArgs e)
        {
            Predeterminado();
            ABeverly.Bev0.Start(picBox, lblTitle, lbl, bttnRight, bttnLeft, player);
        }

        private void bttnRight_Click_1(object sender, EventArgs e)
        {
            if (bttnRight.Text == "Exit")
            {
                playerChoices.addToList("GAME OVER");
                MessageBox.Show("GAME OVER");
                fileManager.listToTxt();
                Close();
            }
            if (bttnRight.Text == "Go back")
            {
                Emvipi();
            }
        }

        private void bttnLeft_Click(object sender, EventArgs e) { }

        private void bttnCenter_Click_1(object sender, EventArgs e)
        {
            Predeterminado();
            AEddie.Eddie0.Start(picBox, lblTitle, lbl, bttnRight, bttnLeft, player);
        }

        private void bttnDown_Click_1(object sender, EventArgs e)
        {
            Predeterminado();
            AStanley.Stanley0.Start(picBox, lblTitle, lbl, bttnRight, bttnLeft, player);
        }

        private void bttnMVP_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void bttnBill_Click_1(object sender, EventArgs e)
        {
            Predeterminado();
            ABill.Bill0.Start(picBox, lblTitle, lbl, bttnRight, bttnLeft, player);
        }

        private void bttnBen_Click_1(object sender, EventArgs e)
        {
            Predeterminado();
            ABen.Starter.startBen(picBox, lblTitle, lbl, bttnRight, bttnLeft, player);
        }

        private void bttnEnd_Click(object sender, EventArgs e)
        {
            Predeterminado();
            Final.End0.Wall(picBox, lblTitle, lbl, bttnRight, bttnLeft, player);
        }

        private void slowRefresh_Tick(object sender, EventArgs e)
        {
            riskChecker.checkRisk(this);
        }

        private void fastRefresh_Tick(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.SuppressFinalize(this);

            lblMoney.Text = Wallet.cash.ToString();
            lblMeds.Text = player.ownedMeds.Count.ToString();
            lblWeapons.Text = player.ownedWeapons.Count.ToString();
            lblTransports.Text = player.ownedTransports.Count.ToString();

            Weapon fist = new Weapon("Fist", 5);
            Weapon kicks = new Weapon("Kicks", 10);
            Weapon knuckles = new Weapon("Knuckles", 8);
            Weapon spit = new Weapon("Spit", 2);
            Weapon uppercut = new Weapon("Uppercut", 5);

            if (globalVar.weapons.Count <= 0)
            {
                player.ownedWeapons.Add(fist);
                player.ownedWeapons.Add(kicks);
                player.ownedWeapons.Add(knuckles);
                player.ownedWeapons.Add(spit);
                player.ownedWeapons.Add(uppercut);
            }
        }
    }
}
