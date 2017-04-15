using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            string x;
            string suit;
            
            //Console.WriteLine("Podaj nr karty(2-14)");
            //x = Console.ReadLine();
            //Int32.Parse(x);
            //Console.WriteLine("Podaj kolor (Diamonds-1,Clubs-2,Hearts-3,Spades-4 ");
            //suit=Console.ReadLine();
            //deck.getCard ("",Int32.Parse(x)-2,Int32.Parse(suit)-1);

            //Console.WriteLine("Randomowa karta ");
            //deck.getRandomCard();

            deck.shuffleDesk();
        }
    }
}
