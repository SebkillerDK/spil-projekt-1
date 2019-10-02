using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig
{

    public enum Kulør
    {
        HJERTER,
        KLØR,
        SPAR,
        RUDER,
    }

    public enum Værdi
    {
        two = 2, tre = 3, fire = 4, fem = 5, seks = 6, syv = 7, otte = 8,
        ni = 9, ti = 10, knægt = 11, droning = 12, konge = 13, es = 14
    }

    public class Kort
    {       
       
        public Kulør Kulør
        {
            get;
            set;

        }
        public Værdi Værdi
        {
            get;
            set;
        }




    }
}

