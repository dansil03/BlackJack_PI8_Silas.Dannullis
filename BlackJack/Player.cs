using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        Deck deck1 = new Deck();
        List<Card> HandKaarten = new List<Card>();
        List<Card> DealerKaarten = new List<Card>();
        public int PuntenTotaal;
        public int PuntenDealer;








       public Player()
       {

            Spel(); 
       }

        public void Spel()
        {
            void BeginSpel()
            {
                void BeginKaarten()
                {
                    HandKaarten.Add(deck1.Shuffled[0]);
                    deck1.Shuffled.RemoveAt(0);
                    HandKaarten.Add(deck1.Shuffled[0]);
                    deck1.Shuffled.RemoveAt(0);

                    int PuntenSpeler()
                    {
                        int Punt1 = HandKaarten[0].Value;
                        int Punt2 = HandKaarten[1].Value;
                        PuntenTotaal = Punt1 + Punt2;
                        return PuntenTotaal;
                    }
                    PuntenSpeler(); 
                    foreach(Card kaart in HandKaarten)
                    {
                        Console.WriteLine("player1: " + kaart.HeleKaart);
                        
                    }
                    Console.WriteLine("Punten: " + PuntenSpeler());
                }
                void BeginDealer()
                {
                    DealerKaarten.Add(deck1.Shuffled[0]);
                    deck1.Shuffled.RemoveAt(0);
                    PuntenDealer = DealerKaarten[0].Value; 

                    foreach(Card kaart in DealerKaarten)
                    {
                        Console.WriteLine("Dealer: " + kaart.HeleKaart);
                        Console.WriteLine("Punten: " + PuntenDealer); 
                    }                   
                }
                BeginKaarten();
                BeginDealer();
            }
            BeginSpel();

            void NieuweKaart()
            {
                if (PuntenTotaal == 21 )
                {
                    Dealer();  
                }

                else if (PuntenTotaal > 21)
                {
                    Console.WriteLine("je hebt te veel");
                    
                }

                else
                {
                    Console.WriteLine("wilt u nog een kaart? ");
                    string Antwoord = Console.ReadLine();

                    if(Antwoord == "ja")
                    {
                        HandKaarten.Add(deck1.Shuffled[0]);
                        deck1.Shuffled.RemoveAt(0); 
                        
                        foreach(var kaart in HandKaarten)
                        {
                            Console.WriteLine("speler1: " + kaart.HeleKaart); 
                        }

                        for (int i = 2; i < HandKaarten.Count; i++)
                        {
                            int NieuwPunten = HandKaarten[i].Value;
                            PuntenTotaal = PuntenTotaal + NieuwPunten; 
                        }

                        Console.WriteLine("punten: " + PuntenTotaal);
                        NieuweKaart();
                    }

                    else if(Antwoord == "nee")
                    {
                        Dealer(); 
                    }
                }
            }
            NieuweKaart(); 

            void Dealer()
            {
                if (PuntenDealer < PuntenTotaal && PuntenDealer < 21)
                {
                    DealerKaarten.Add(deck1.Shuffled[0]);
                    PuntenDealer = PuntenDealer + deck1.Shuffled[0].Value;
                    deck1.Shuffled.RemoveAt(0); 
                    foreach(var kaart in DealerKaarten)
                    {
                        Console.WriteLine("Dealer: " + kaart.HeleKaart); 
                    }
                    Console.WriteLine("punten: " + PuntenDealer);

                    Dealer(); 
                }
                

                if (PuntenDealer > 21)
                {
                    Console.WriteLine("je hebt gewonnen!"); 
                }

                else if(PuntenDealer <= 21 && PuntenDealer > PuntenTotaal)
                {
                    Console.WriteLine("je hebt verloren!"); 
                }

                else if(PuntenTotaal == PuntenDealer)
                {
                    Console.WriteLine("Push!"); 
                }                
            }            
        }   
    }
}
