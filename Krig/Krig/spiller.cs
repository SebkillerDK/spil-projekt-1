using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig
{
    public class Spiller
    {
        public List<Kort> bunke;
        private string navn;
        public string Navn { get { return this.navn; } set { this.navn = value; } }

        public Spiller(string spillernavn)
        {
            Navn = spillernavn;
            bunke = new List<Kort>();
        }     
        
    }
}