using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class ClasseRectangle : Classe4Angles
    {
        #region Propriétés
        private int largeur;
        #endregion


        #region Constructeurs
        public ClasseRectangle()
        {
            this.Init();
            
        }
        #endregion



        #region Accesseurs/Mutateurs
        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }
        #endregion

        #region Methodes
        public void Dessin() { }

        public new void Init()
        {
            Random rnd = new Random();
            largeur = rnd.Next(1,Globals.max); //Initialise un nombre aléatoire entre 0 et 15
            
            // Pour éviter d'avoir un carré, on fait en sorte que la largeur soit différente de la hauteur (uneValeur)
            while (largeur == uneValeur)
            {
                largeur = rnd.Next(1,Globals.max);
            }
        }

        public int Perimetre() { return Multiplication(Addition(UneValeur, largeur), 2); }

        public int Surface() { return Multiplication(UneValeur, largeur); }
        #endregion
    }
}

