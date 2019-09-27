using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StenSaksPapir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast spiller 1 ");
            string spiller1 = Console.ReadLine();
            Console.WriteLine("indtast spiller 2 ");
            string spiller2 = Console.ReadLine();

            Console.Clear();

            string spiligen = "ja";
            while (spiligen == "ja")
            {
                Console.Clear();

                bool dum;
                int våben1, våben2;
                do
                {
                    Console.WriteLine(" vælg dit våben " + spiller1);
                    Console.WriteLine(" 1:Sten \n 2:Saks \n 3:Papir");

                    string input1 = Console.ReadLine();
                    dum = int.TryParse(input1, out våben1);
                    Console.Clear();
                }
                while (dum == false);

               
                do
                {
                    Console.WriteLine(" vælg dit våben " + spiller2);
                    Console.WriteLine(" 1:Sten \n 2:Saks \n 3:Papir");

                    string input2 = Console.ReadLine();
                    dum = int.TryParse(input2, out våben2);
                    Console.Clear();
                }
                while (dum == false);


                //Uafgjort
                if (våben1 == våben2 && våben1 < 4 && våben1 > 0 && våben2 < 4 && våben2 > 0)
                {
                    Console.WriteLine(" Kampen er uafgjort prøv igen. ");
                }

                //sten vs saks
                else if (våben1 == 1 && våben2 == 2)
                {
                    Console.WriteLine(spiller1 + " Har vundet! ");
                }
                else if (våben1 == 2 && våben2 == 1)
                {
                    Console.WriteLine(spiller2 + " Har vundet! ");
                }

                //sten vs papir
                else if (våben1 == 1 && våben2 == 3)
                {
                    Console.WriteLine(spiller2 + " Har vundet! ");
                }
                else if (våben1 == 3 && våben2 == 1)
                {
                    Console.WriteLine(spiller1 + " Har vundet! ");
                }

                //papir vs saks
                else if (våben1 == 2 && våben2 == 3)
                {
                    Console.WriteLine(spiller1 + " Har vundet! ");
                }
                else if (våben1 == 3 && våben2 == 2)
                {
                    Console.WriteLine(spiller2 + " Har vundet! ");
                }

                else if (våben1 > 3 || våben2 > 3 || våben1 < 1 || våben2 < 1)
                {
                    Console.WriteLine(" der var en forkert værdi spillet kan ikke forsætte ");
                }
                
                
                Console.WriteLine("\nSpil igen?\n ja/nej");
                spiligen = Console.ReadLine();

                
            }
        }
    }
}
