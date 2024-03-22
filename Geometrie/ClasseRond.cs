using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class ClasseRond : ClasseCalcul
    {
        public ClasseRond() { }


        public void Dessin() { }

        public new void Init()
        {
            base.Init();
        }

        public int Perimetre() { return Multiplication(Multiplication(3, 2),UneValeur); }

        public int Surface() { return Multiplication(Multiplication(uneValeur, uneValeur), 2); }
        
    }




}

