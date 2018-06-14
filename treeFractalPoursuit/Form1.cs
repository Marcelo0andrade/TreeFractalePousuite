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
/*
 *  Projet: TreeFractalPoursuit
 *  Auteur: Marcelo Andrade
 *  Date: 18.05.2018  
 *  Classe: 1M4I1C
 *  Version: Microsoft Visual studio pro 2017
 *  OS: Win 10 Pro
 *  But: Générer un arbre fractale
*/
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
            //envoyer les valeurs à la classe                                                                                                                                                                                                                                                                       
            arbre.AngleA = (float)nudAngleA.Value;
            arbre.AngleB = (float)nudAngleB.Value;                                                                                                                                                                                                                     
            arbre.LongueurBrancheB = (float)nudLongueurB.Value;                                                                                                                                                                                                                 
            arbre.NiveauFeuille = (float)nudNiveau.Value;                                                                                                                                                                                                                    
            arbre.Hiver = rbtnHiver.Checked;                                                                                                                                                                                                                                   
            arbre.Ete = rbtnEte.Checked;                                                                                                                                                                                                                                      
            arbre.Printemps = rbtnPrintemps.Checked;                                                                                                                                                                                                                   
            arbre.Automne = rbtnAutomne.Checked;
            //Gérer le label de version                                                                                                                                                                                                                                                                  
            lblNomVersion.Left = ClientRectangle.Width - 143;
            lblNomVersion.Top = ClientRectangle.Height - 25;

            //Volume de la musique de fond
            axWindowsMediaPlayer1.settings.volume = 50;

        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            //Mettre une sorte de plafond à cause du nombre de calcules à éffectuer
            if (nudLongueurA.Value >= 0.70m && nudLongueurB.Value >= 0.70m &&nudNiveau.Value>=18)
            {
                nudLongueurA.Value = 0.70m;
                nudLongueurB.Value = 0.70m;
                nudNiveau.Value = 18m;
            }

            arbre.Hiver = rbtnHiver.Checked;
            arbre.Ete = rbtnEte.Checked;
            arbre.Printemps = rbtnPrintemps.Checked;
            arbre.Automne = rbtnAutomne.Checked;

            btnAleatoire.Enabled = false;
            Redimentionner();
            btnAleatoire.Enabled = true;
        }
        //Donne le focus pour pouvoir faire Enter directement dans le bouton "générer"
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
            lblNomVersion.Left = ClientRectangle.Width - 148;
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

        private void btnAleatoire_Click(object sender, EventArgs e)
        {
            nudAngleA.Value = Convert.ToDecimal(arbre.randomsAngles());
            nudLongueurB.Value = Convert.ToDecimal(arbre.randomsLongueur());
            nudLongueurA.Value = Convert.ToDecimal(arbre.randomsLongueur());
            nudAngleB.Value = Convert.ToDecimal(arbre.randomsAngles());
            btnAleatoire.Enabled = false;
            Redimentionner();
            btnAleatoire.Enabled = true;
        }
    }
}
//                                             .         ;  
//                .              .              ;%     ;;   
//                  ,           ,                :;%  %;   
//                   :         ;                   :;%;'     .,   
//          ,.        %;     %;            ;        %;'    ,;
//            ;       ;%;  %%;        ,     %;    ;%;    ,%'
//             %;       %;%;      ,  ;       %;  ;%;   ,%;' 
//              ;%;      %;        ;%;        % ;%;  ,%;'
//               `%;.     ;%;     %;'         `;%%;.%;'
//                `:;%.    ;%%. %@;        %; ;@%;%'
//                   `:%;.  :;bd%;          %;@%;'
//                     `@%:.  :;%.         ;@@%;'   
//                       `@%.  `;@%.      ;@@%;         
//                         `@%%. `@%%    ;@@%;        
//                           ;@%. :@%%  %@@%;       
//                             %@bd%%%bd%%:;     
//                               #@%%%%%:;;
//                               %@@%%%::;
//                               %@@@%(o);  . '         
//                               %@@@o%;:(.,'         
//                           `.. %@@@o%::;         
//                              `)@@@o%::;         
//                               %@@(o)::;        
//                              .%@@@@%::;         
//                              ;%@@@@%::;.          
//                             ;%@@@@%%:;;;. 
//                         ...;%@@@@@%%:;;;;,..  