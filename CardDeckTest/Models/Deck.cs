using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardDeckTest.Models
{
    public class Deck
    {
        public List<Card> cards { get; set; }

        public Deck()
        {
            var cards = new List<Card>();

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
                    var card = new Card(suit, rank);
                    cards.Add(card);
                }
            }

            this.cards = cards;
        }
    }
}