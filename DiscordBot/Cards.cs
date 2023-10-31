using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class CardSystem
    {
        public int[] cardNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        public string[] cardSuits = { "Clubs", "Spades", "Diamonds", "Hearts" };

        public CardSystem() 
        {
            var random = new Random();
            
        }
    }
}
