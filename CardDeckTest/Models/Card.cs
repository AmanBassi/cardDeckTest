using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardDeckTest.Models
{
    public enum Suits
    {
        Clubs,
        Spades,
        Hearts,
        Diamonds
    };

    public enum Ranks
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    };


    public class Card
    {
        public Suits Suit { get; set; }
        public Ranks Rank { get; set; }

        public Card (Suits suit, Ranks rank)
        {
            this.Rank = rank;
            this.Suit = suit;
        }
    }
}