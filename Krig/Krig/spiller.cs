using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig
{
    class Spiller
    {
        public List<Kort> bunke;
        public string navn;

        public Spiller(string spillernavn)
        {
            navn = spillernavn;
            bunke = new List<Kort>();
        }     
        
    }
}