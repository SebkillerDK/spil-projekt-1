using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");

            KortBunke hovedBunke = new KortBunke();
            hovedBunke.lavBunkeKort();

            Console.WriteLine("Indtast navn for spiller1: ");
            Spiller spiller1 = new Spiller(Console.ReadLine());
            Console.WriteLine("Indtast navn for spiller2: ");
            Spiller spiller2 = new Spiller(Console.ReadLine());

            hovedBunke.givKort(spiller1, spiller2);     
            

    
            Console.ReadLine();

            
        }
    }
}
