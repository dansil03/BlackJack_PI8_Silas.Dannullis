using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public List<Card> deck = new List<Card>();
        public List<Card> Shuffled = new List<Card>();
        
        public Deck()
        {

            string[] suits = { "Harten", "Schoppen", "Klaver", "Ruiten" };
            string[] ranksTien = {"Boer", "Koningin", "Koning" };
            
            foreach(string suit in suits)
            {
                foreach (string rank in ranksTien)
                {                     
                    Card card1 = new Card(suit, rank, 10);
                    deck.Add(card1); 
                }
            }

            foreach (var suit in suits)
            {
                for (int i = 2; i < 11; i++)
                {                    
                    Card card2 = new Card(suit, i.ToString(), i);
                    deck.Add(card2); 
                }
            }
            Shuffle(); 
            
        }
        public void Shuffle()
        {
            for (int i = 0; i < 48; i++)
            {
                var random = new Random();
                int r = random.Next(deck.Count);
                Card RandomKaart = deck[r];
                Shuffled.Add(RandomKaart);
                deck.RemoveAt(r); 
            }
        }         
	}         
}