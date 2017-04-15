using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            string nazwa;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 13; j++)
                {
                    if (i == 0)
                    {
                        nazwa = "Diamond";
                        cards.Add(new Card(nazwa, j));
                        
                    }
                    if (i == 1)
                    {
                        nazwa = "Clubs";
                        cards.Add(new Card(nazwa, j));
                    }
                    if (i == 2)
                    {
                        nazwa = "Hearts";
                        cards.Add(new Card(nazwa, j));
                    }
                    if (i == 3)
                    {
                        nazwa = "Spades";
                        cards.Add(new Card(nazwa, j));
                    }
                }

        }

            public void getCard(string nazwa,int rank,int suit)
        {
            //cards.ForEach(delegate (Card card)
            //{
            //    Console.WriteLine(card.getString() +" " + card.getRank(rank));
            //});

            //Card card;
          
            //Console.WriteLine(cards[suit*13].getString() + " " + cards[rank].getRank(rank));



            //  return cards[rank];
        }

        public void getRandomCard()
        {
            Random rnd = new Random();

            int rndSuit = rnd.Next(0, 4);
            int rndRank = rnd.Next(0, 13);

            //Console.WriteLine(cards[rndSuit * 13].getString() + " "+ cards[rndRank].getRank(rndRank));
        }

        public void shuffleDesk()
        {
            Random rnd = new Random();
            for (var i = 0; i < cards.Count ; i++)
            {
                var j = rnd.Next(i, cards.Count);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
    }
}
