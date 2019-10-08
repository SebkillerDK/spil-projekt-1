using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig
{
    public class Spil
    {
        private Spiller Spiller1;
        private Spiller Spiller2;
        public int Omgang;
        public Spil(string spiller1navn, string spiller2navn)
        {
            Spiller1 = new Spiller(spiller1navn);
            Spiller2 = new Spiller(spiller2navn);

            KortBunke hovedBunke = new KortBunke();
            hovedBunke.lavBunkeKort();
            hovedBunke.givKort(Spiller1, Spiller2);

        }

        public bool ErSpilSlut()
        {
            if (!Spiller1.bunke.Any())
            {
                Console.WriteLine(Spiller1.Navn + " Har ikke flere kort!  " + Spiller2.Navn + " VINDER!");
                Console.WriteLine("Omgange: " + Omgang.ToString());
                return true;
            }
            else if (!Spiller2.bunke.Any())
            {
                Console.WriteLine(Spiller2.Navn + " Har ikke flere kort!  " + Spiller1.Navn + " VINDER!");
                Console.WriteLine("Omgange: " + Omgang.ToString());
                return true;
            }
            else if (Omgang > 1000)
            {
                Console.WriteLine("Spillet blev for langt!  Vi stopper her.");
                return true;
            }
            return false;
        }

        public void PlayTurn()
        {
            List<Kort> pulje = new List<Kort>();

            Kort spiller1kort = Spiller1.bunke[0];
            var player2card = Spiller2.bunke.Dequeue();

            pulje.Add(spiller1kort);
            pulje.Enqueue(player2card);

            Console.WriteLine(Spiller1.Navn + " plays " + spiller1kort.DisplayName + ", " + Spiller2.Navn + " plays " + player2card.DisplayName);

            while (spiller1kort.MinVærdi == player2card.Minværdi)
            {
                Console.WriteLine("WAR!");
                if (Spiller1.Deck.Count < 4)
                {
                    Spiller1.Deck.Clear();
                    return;
                }
                if (Spiller2.Deck.Count < 4)
                {
                    Spiller2.Deck.Clear();
                    return;
                }

                pulje.Enqueue(Spiller1.Deck.Dequeue());
                pulje.Enqueue(Spiller1.Deck.Dequeue());
                pulje.Enqueue(Spiller1.Deck.Dequeue());
                pulje.Enqueue(Spiller2.Deck.Dequeue());
                pulje.Enqueue(Spiller2.Deck.Dequeue());
                pulje.Enqueue(Spiller2.Deck.Dequeue());

                spiller1kort = Spiller1.Deck.Dequeue();
                player2card = Spiller2.Deck.Dequeue();

                pulje.Enqueue(spiller1kort);
                pulje.Enqueue(player2card);

                Console.WriteLine(Spiller1.Name + " plays " + spiller1kort.DisplayName + ", " + Spiller2.Name + " plays " + player2card.DisplayName);
            }

            if (spiller1kort.Value < player2card.Value)
            {
                Spiller2.Deck.Enqueue(pulje);
                Console.WriteLine(Spiller2.Name + " takes the hand!");
            }
            else
            {
                Spiller1.Deck.Enqueue(pulje);
                Console.WriteLine(Spiller1.Name + " takes the hand!");
            }

            Omgang++;
        }
    }
}
