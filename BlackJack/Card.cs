using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public string Rank;
        public string Suit;
        public string HeleKaart; 
        public int Value;


        public Card(string _suit, string _rank, int _value)
        {
            Suit = _suit;
            Rank = _rank;
            Value = _value;
            HeleKaart = _suit + " " + _rank;




        }

        public override string ToString()
        {
            return string.Format(Suit, Rank);
        }
    }
}
