using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class ClasseTriangle : ClasseAvecAngle
    {
        public int C1;
        public int C2;
        public int Haut;



        public int _C1
        {
            get { return C1; }
            set { C1 = value; }
        }

        public int _C2
        {
            get { return C2; }
            set { C2 = value; }
        }

        public int _Haut
        {
            get { return Haut; }
            set { Haut = value; }
        }

        public ClasseTriangle()
        {
            this.Init();
        }
        public new void Init()
        {
            Random nb = new Random();
            C1 = nb.Next(1, Globals.max);

            while (C1 == uneValeur)
            {
                C1 = nb.Next(1, Globals.max);
            }




            Random nb2 = new Random();
            C2 = nb2.Next(1, Globals.max);

            while (C2 == uneValeur)
            {
                C2 = nb2.Next(1, Globals.max);
            }




            Random nb3 = new Random();
            Haut = nb3.Next(1, Globals.max);

            while (Haut == uneValeur)
            {
                Haut = nb3.Next(1, Globals.max);
            }
        }

        public int Perimetre()
        {
            return Addition(Addition(C1, C2), uneValeur);
        }

        public int Surface()
        {
            return Multiplication(Multiplication(uneValeur, Haut), Convert.ToInt32(0.5));
        }
    }
}
