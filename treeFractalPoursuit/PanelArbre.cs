using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.Modeling.Integration;

namespace treeFractalPoursuit
{
    public class PanelArbre : Panel
    {
        private float _longeurBrancheA, _longeurBrancheB, _angleA ,_angleB, _NiveauFeuille;
        private bool _Hiver,_Ete,_Automne,_Printemps; 
        LinearGradientBrush LinDeg;
        Random rnd = new Random();
        public bool Hiver
        {get{return _Hiver;}set{_Hiver = value;Invalidate();}}
        public bool Ete
        {get{return _Ete;}set{_Ete = value;Invalidate();}}
        public bool Automne
        {get{return _Automne;}set{_Automne = value;Invalidate();}}
        public bool Printemps
        {get{return _Printemps;}set{_Printemps = value;Invalidate();}}
        public float AngleA
        {get{return _angleA;}set{_angleA = value;Invalidate();}}
        public float AngleB
        {get{return _angleB;}set{_angleB = value;Invalidate();}}
        public float LongueurBrancheA
        {get{return _longeurBrancheA;}set{_longeurBrancheA = value;Invalidate();}}
        public float LongueurBrancheB
        {get{return _longeurBrancheB;}set{ _longeurBrancheB = value; Invalidate();}}
        public float NiveauFeuille
        {get{return _NiveauFeuille;}set{_NiveauFeuille = value;Invalidate();}}

        /// <summary>
        /// Valeurs par défaut
        /// </summary>
        public PanelArbre(int largeur, int hauteur) : base()
        {
            this.Paint += new PaintEventHandler(Redessiner);
            
            BackColor = SystemColors.ControlDarkDark;
            AutoScroll = true;
            Width = largeur;
            Height = hauteur;  
        }
        /// <summary>
        /// Recommence le dessin
        /// </summary>
        private void Redessiner(object sender, PaintEventArgs e)
        {
            //hauteur de branche
            float fLongueur = Height/4;
            e.Graphics.TranslateTransform(Width / 2, Height);
            
           
            DessinerBranche(e.Graphics, fLongueur);
        }

        /// <summary>
        ///  Dessiner les branches
        /// </summary>
        public void DessinerBranche(Graphics gr, float fLongueur)
        {
            Couleur();
            //Tourner,aller et dessiner
            if (fLongueur > 24 - NiveauFeuille)
            {
              
                Pen pen = new Pen(LinDeg, 8);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                gr.DrawLine(pen, 0, 0, 0, -fLongueur);
                gr.TranslateTransform(0, -fLongueur);
                GraphicsState normal = gr.Save();

                //branche droite dessin
                gr.RotateTransform(Convert.ToInt32(Math.PI * AngleA/180));
                DessinerBranche(gr, fLongueur * LongueurBrancheA);

                //branche Gauche dessin
                gr.Restore(normal);
                gr.RotateTransform(Convert.ToInt32(Math.PI * AngleB / 180));
                DessinerBranche(gr,fLongueur * LongueurBrancheB);
            }
        }

        /// <summary>
        /// Random des longueurs des branches
        /// </summary>
        public float randomsLongueur()
        {
            double Longueur=0;
            
            Longueur = rnd.Next(10, 80);
            Longueur *= (double)0.01;
            return (float)Longueur;
        }
        /// <summary>
        /// Random des angles des branches
        /// </summary>
        public float randomsAngles()
        {
            int Angle=0;
            Angle=rnd.Next(-6000,6000);
            return Angle;
        }
        /// <summary>
        /// Random des couleurs des branches
        /// </summary>
        private void Couleur()
        {
            const int VALEURMAXDEGRES = 256;
            int Rouge;
            int Vert;
            int Bleu;
            
            //Faire un dégradé
            int iX = rnd.Next(1, VALEURMAXDEGRES);
            if (Hiver)
            {
                Rouge = 0;
                Vert = iX * 165 / VALEURMAXDEGRES;
                Bleu = 255;
            }
            else if (Ete)
            {
                Rouge = 10;
                Vert = 200;
                Bleu = iX * 165 / VALEURMAXDEGRES;
                
            }
            else if (Automne)
            {
                Rouge = 255;
                Vert = iX * 165 / VALEURMAXDEGRES;
                Bleu = 0;
            }
            else if (Printemps)
            {
                Rouge = iX * 165 / VALEURMAXDEGRES;
                Vert = 0;
                Bleu = 200;
            }
            else
            {
                Rouge = 255;
                Vert = iX * 165 / VALEURMAXDEGRES;
                Bleu = 0;
            }

            //Dégradé linéaire
            LinDeg = new LinearGradientBrush(
            new Point(0, 10),
            new Point(200, 10),
            Color.FromArgb(100, 0, 0, 0),
            Color.FromArgb(255, Rouge,Vert,Bleu));
            
        }
    }
}