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
        private float _longeurBrancheA;
        private float _longeurBrancheB;
        private float _angleA;
        private float _angleB;
        private float _NiveauFeuille;
        private bool _Hiver;
        private bool _Ete;
        private bool _Automne;
        private bool _Printemps; 
        LinearGradientBrush LinDeg;
        public bool Hiver
        {
            get
            {
                return _Hiver;
            }
            set
            {
                _Hiver = value;
                Invalidate();
            }
        }
        public bool Ete
        {
            get
            {
                return _Ete;
            }
            set
            {
                _Ete = value;
                Invalidate();
            }
        }
        public bool Automne
        {
            get
            {
                return _Automne;
            }
            set
            {
                _Automne = value;
                Invalidate();
            }
        }
        public bool Printemps
        {
            get
            {
                return _Printemps;
            }
            set
            {
                _Printemps = value;
                Invalidate();
            }
        }
        public float AngleA
        {
            get
            {
                return _angleA;
            }
            set
            {
                _angleA = value;
                Invalidate();
            }
        }


        public float AngleB
        {
            get
            {
                return _angleB;
            }
            set
            {
                _angleB = value;
                Invalidate();
            }
        }
        public float LongueurBrancheA
        {
            get
            {
                return _longeurBrancheA;
            }
            set
            {

                _longeurBrancheA = value;
                Invalidate();
            }
        }
        public float LongueurBrancheB
        {
            get
            {
                return _longeurBrancheB;
            }
            set
            {
                _longeurBrancheB = value;
                Invalidate();
            }
        }
        public float NiveauFeuille
        {
            get
            {
                return _NiveauFeuille;

            }
            set
            {
                _NiveauFeuille = value;
                Invalidate();

            }
        }

        public PanelArbre(int largeur, int hauteur) : base()
        {
            this.Paint += new PaintEventHandler(Redessiner);
            BackColor = SystemColors.ControlDarkDark;
            AutoScroll = true;
            Width = largeur;
            Height = hauteur;
            
        }

        private void Redessiner(object sender, PaintEventArgs e)
        {
            
            float fLongueur = Height/4;
            e.Graphics.TranslateTransform(Width / 2, Height);
            
            //Dessiner les branches
            DessinerBranche(e.Graphics, fLongueur);
        }

        public void DessinerBranche(Graphics gr, float fLongueur)
        {
            Couleur();
            //Tourner,aller et dessiner
            if (fLongueur > 22 - NiveauFeuille)
            {
              
                Pen pen = new Pen(LinDeg, 8);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                gr.DrawLine(pen, 0, 0, 0, -fLongueur);
                gr.TranslateTransform(0, -fLongueur);
                GraphicsState normal = gr.Save();

                //branche droite dessin
                gr.RotateTransform(AngleA);
                DessinerBranche(gr, fLongueur * LongueurBrancheA);
                //branche Gauche dessin
                gr.Restore(normal);
                gr.RotateTransform(AngleB);
                DessinerBranche(gr, fLongueur * LongueurBrancheB);
            }
        }
        private void Couleur()
        {
            int ValeurMaxDegrade = 255;
            int Rouge;
            int Vert;
            int Bleu;
            
            //Faire un dégradé
            Random rnd = new Random();
            int iX = rnd.Next(70, ValeurMaxDegrade);
            if (Hiver)
            {
                Rouge = 0;
                Vert = iX * 165 / ValeurMaxDegrade;
                Bleu = 255;
            }
            else if (Ete)
            {
                Rouge = 0;
                Vert = 255;
                Bleu = iX * 165 / ValeurMaxDegrade;
                
            }
            else if (Automne)
            {
                Rouge = 255;
                Vert = iX * 165 / ValeurMaxDegrade;
                Bleu = 0;
            }
            else if (Printemps)
            {
                Rouge = iX * 165 / ValeurMaxDegrade;
                Vert = 0;
                Bleu = 200;
            }
            else
            {
                Rouge = 255;
                Vert = iX * 165 / ValeurMaxDegrade;
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