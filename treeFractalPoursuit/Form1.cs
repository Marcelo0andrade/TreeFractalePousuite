using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeFractalPoursuit
{
    public partial class Form1 : Form
    {
        private PanelArbre arbre;

        public Form1()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Faire en sorte que le panel sois en pleine écran
            arbre = new PanelArbre(ClientRectangle.Width, ClientRectangle.Height);

            //Classe qui gère l'interface graphique et l'algorithme de l'arbre
            Controls.Add(arbre);

            arbre.AngleA = (float)nudAngleA.Value;
            arbre.AngleB = (float)nudAngleB.Value;
            arbre.LongueurBrancheA = (float)nudLongueurA.Value;
            arbre.LongueurBrancheB = (float)nudLongueurB.Value;
            arbre.NiveauFeuille = (float)nudNiveau.Value;
            arbre.Hiver = rbtnHiver.Checked;
            arbre.Ete = rbtnEte.Checked;
            arbre.Printemps = rbtnPrintemps.Checked;
            arbre.Automne = rbtnAutomne.Checked;
            lblNomVersion.Left = ClientRectangle.Width - 143;
            lblNomVersion.Top = ClientRectangle.Height - 25;


            //Mettre une musique en fond
            wbbMusic.Navigate("https://www.youtube.com/watch?v=SHgdecrfEEk");

        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            this.Focus();
            arbre.Hiver = rbtnHiver.Checked;
            arbre.Ete = rbtnEte.Checked;
            arbre.Printemps = rbtnPrintemps.Checked;
            arbre.Automne = rbtnAutomne.Checked;

            Redimentionner();
        }
        //Donne le focus pour pouvoir faire Enter directement
        private void nudAngleB_ValueChanged(object sender, EventArgs e)
        {
            btnGenerer.Focus();

        }

        private void nudLongueurB_ValueChanged(object sender, EventArgs e)
        {
            btnGenerer.Focus();

        }

        private void nudAngleA_ValueChanged(object sender, EventArgs e)
        {
            btnGenerer.Focus();

        }

        private void nudLongueurA_ValueChanged(object sender, EventArgs e)
        {
            btnGenerer.Focus();
        }

        private void Fenetre_Tick(object sender, EventArgs e)
        {
            //Gérer la fenêtre
            lblNomVersion.Left = ClientRectangle.Width - 143;
            lblNomVersion.Top = ClientRectangle.Height - 25;
            arbre.Width = ClientRectangle.Width; 
            arbre.Height= ClientRectangle.Height;
        }
        //Gérer le fait de Redessiner après avoir redimentionner
        private void Redimentionner()
        {
            arbre.LongueurBrancheB = (float)nudLongueurB.Value;
            arbre.LongueurBrancheA = (float)nudLongueurA.Value;
            arbre.AngleB = (float)nudAngleB.Value;
            arbre.AngleA = (float)nudAngleA.Value;
            arbre.NiveauFeuille = (float)nudNiveau.Value;
        }
    }
}
   