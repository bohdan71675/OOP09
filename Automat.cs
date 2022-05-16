using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP09
{
    class Automat : Stroj
    {
        private int kolikKratServisovan = 0;
        private bool preprogramovan;

        public Automat(string evidencniCislo, DateTime uvedenDoProvozu, bool preprogramovan) : base(evidencniCislo, uvedenDoProvozu)
        {
            this.preprogramovan = preprogramovan;
        }
        public void Preprogramuj()
        {
            preprogramovan = true;
        }

        public override void ProvedServis()
        {
            if (preprogramovan)
            {
                System.Windows.Forms.MessageBox.Show("Nelze provest servis, byl preprogramovan");
            }
            else
            {
                base.ProvedServis();
                kolikKratServisovan += 1;
            }
        }

        public override string ToString()
        {
            if (preprogramovan)
            {
                return base.ToString() + " \n BYL PREPROGRAMOVAN  " + "  \n  Byl servisovan " + kolikKratServisovan;
            }
            else
            {
                return base.ToString() + " \n NEBYL PREPROGRAMOVAN  " + "  \n  Byl servisovan " + kolikKratServisovan;
            }
        }

    }
}
