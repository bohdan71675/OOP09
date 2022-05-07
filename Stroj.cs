﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP09
{
    class Stroj
    {
        protected string evidencniCislo;
        protected DateTime uvedenDoProvozu;
        protected DateTime posledniServis = new DateTime();

        public string EvidencniCislo
        {
            get
            { return evidencniCislo; }
            set
            {
                string s = value;
                if (!char.IsLetter(s[0]) && !char.IsLetter(s[1]))
                {
                    s = s.Insert(0, "A");
                    s = s.Insert(1, "A");
                }
                else if (!char.IsLetter(s[0]))
                {
                    s = s.Insert(0, "A");
                }
                else if (!char.IsLetter(s[1]))
                {
                    s = s.Insert(1, "A");
                }

                evidencniCislo = s;
            }
        }

        public DateTime UvedenDoProvozu
        {
            get
            { return uvedenDoProvozu; }
            set
            {
                uvedenDoProvozu = value;
            }
        }


        public Stroj(string evidencniCislo, DateTime uvedenDoProvozu)
        {
            EvidencniCislo = evidencniCislo;
            UvedenDoProvozu = uvedenDoProvozu;
        }

        public virtual void ProvedServis()
        {
            DateTime muzeBytZnovuVServisu = posledniServis.AddDays(42);

            if (DateTime.Today >= muzeBytZnovuVServisu)
            {
                posledniServis = DateTime.Today;
            }
        }


        public override string ToString()
        {
           return base.ToString() + " Evidencni cislo: " + EvidencniCislo + "  Uveden do provozu: " + UvedenDoProvozu.ToShortDateString()
                                  + "  Datum posledniho servisu:  " + posledniServis.ToShortDateString();
        }
    }
}
