using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class ClasseCarre : Classe4Angles
    {
        #region Constructeurs
        public ClasseCarre() {}
        #endregion

        #region Methodes
        public void Dessin() {
        
        }
        
        public new void Init() {
            base.Init();
            //Rien à initialiser, UneValeur est initialisé dans la classe mère ClasseCalcul
        }

        public int Perimetre() { return Multiplication(UneValeur,4); }
        
        public int Surface() { return Multiplication(UneValeur,UneValeur); }
        #endregion
    }
}
