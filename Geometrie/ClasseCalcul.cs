using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class ClasseCalcul
    {

        #region Champs
        protected int uneValeur;
        #endregion

        #region Constructeurs
        public ClasseCalcul()
        {
            this.Init();
        }
        #endregion

        #region Accesseurs/Mutateurs
        public int UneValeur
        {
            get { return uneValeur; }
            set { uneValeur = value; }
        }
        #endregion

        #region Méthodes
        public void Init()
        {
            Random rnd = new Random();
            UneValeur = rnd.Next(1, Globals.max);
            
            // Pour éviter d'avoir 2 fois à la suite le même chiffre aléatoire.
            while (UneValeur == Globals.oldUneValeur)
            {
                UneValeur = rnd.Next(1, Globals.max);
            }
        }


        public int Addition(int c1, int c2)
        {
            return c1 + c2;
        }


        public int Multiplication(int c1, int c2)
        {
            return c1 * c2;
        }
        #endregion
    }


}

