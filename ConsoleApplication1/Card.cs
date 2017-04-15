using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Card
    {
        private int rank;
        private int suit;
        private string nazwa;
       

        public Card(string nazwa,int rank)
        {
            this.rank = rank;
            this.nazwa = nazwa;
            
        }

        public Ranks getRank(int licznik)
        {
            Ranks rank = (Ranks)licznik;
            return rank;
        }
        public string getString()
        {
            return nazwa;
        }
    }
}
