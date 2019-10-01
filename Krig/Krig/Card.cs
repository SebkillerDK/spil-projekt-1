using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig
{
    public class Card
    {
        public int Value;
        public static string[] SuitsArray = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
        public string Suit;

        public Card(int value, string suit)
        {
            Value = value;
            Suit = suit;

        }
        public Card(string input)
        {
            string tempValue = "";
            string suitSentence = "";
            switch (Value)
            {
                case 1:
                    tempValue = "Ace";
                    break;
                case 2:
                    tempValue = "king";
                    break;
                case 3:
                    tempValue = "Queen";
                    break;
                case 4:
                    tempValue = "Jack";
                    break;
                case 5:
                    tempValue = "10";
                    break;
                case 6:
                    tempValue = "9";
                    break;
                case 7:
                    tempValue = "8";
                    break;
                case 8:
                    tempValue = "7";
                    break;
                case 9:
                    tempValue = "6";
                    break;
                case 10:
                    tempValue = "5";
                    break;
                case 11:
                    tempValue = "4";
                    break;
                case 12:
                    tempValue = "3";
                    break;
                case 13:
                    tempValue = "2";
                    break;
                default:
                    tempValue = Value.ToString();
                    break;
            }
            switch (Suit)
            {
                case "Hearts":
                    suitSentence = " of Hearts";
                    break;
                case "Diamonds":
                    suitSentence = " of Diamonds";
                    break;
                case "Clubs":
                    suitSentence = " of Clubs";
                    break;
                case "Spades":
                    suitSentence = " of Spades";
                    break;
            }
            input = tempValue + suitSentence;

        }
    }
}

