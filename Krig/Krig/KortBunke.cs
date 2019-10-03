using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig
{
    class KortBunke : Kort
    {
        const int ANTAL_KORT = 52; //antal af kort
        private Kort[] bunke; // array af alle spillekort

        public KortBunke()
        {
            bunke = new Kort[ANTAL_KORT];
        }

        public Kort[] hentBunke { get { return bunke; } } // hent nuværende bunke kort

        // lav en bunke kort bestående af 52 kort med 13 værdier og 4 kulører
        public void lavBunkeKort()
        {
            int i = 0;
            foreach(Kulør k in Enum.GetValues(typeof(Kulør)))
            {
                foreach(Værdi v in Enum.GetValues(typeof(Værdi)))
                {
                    bunke[i] = new Kort { MinKulør = k, MinVærdi = v };
                    i++;
                }
            }
            BlandKort();
            givKort();
        }

        private void givKort(spiller spiller1, spiller spiller2)
        {
            //tilpads så hver spiller for hver deres halvdel af bunken

            // første 26 kort til spiller1
            for (int i = 0; i < 26; i++)
                spiller1[i] = hentBunke[i];

            // sidste 26 kort til spiller2
            for (int i = 26; i < 52; i++)
                spiller2[i - 26] = hentBunke[i];

        }

        // bland bunken af kort
        public void BlandKort()
        {
            Random rand = new Random();
            Kort temp;

            // kør blandefunktion 1000 gange
            for (int blandGange = 0; blandGange < 1000; blandGange++)
            {
                for (int i = 0; i < ANTAL_KORT; i++)
                {
                    // bland kort
                    int andetKortIndex = rand.Next(13);
                    temp = bunke[i];
                    bunke[i] = bunke[andetKortIndex];
                    bunke[andetKortIndex] = temp;
                }
            }
        }
    }
}
