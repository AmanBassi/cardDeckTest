using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CardDeckTest.Models;

namespace CardDeckTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateDeck()
        {
            return Json(ShuffleDeck(new Deck()), JsonRequestBehavior.AllowGet);
        }

        public Deck ShuffleDeck(Deck deck)
        {
            Random random = new Random();

            int size = deck.cards.Count;

            while (size > 1)
            {
                size--;
                int position = random.Next(size + 1);
                Card temp = deck.cards[position];
                deck.cards[position] = deck.cards[size];
                deck.cards[size] = temp;
            }

            return deck;
        }
    }
}