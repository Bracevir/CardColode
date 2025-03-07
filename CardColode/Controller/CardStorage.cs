using CardColode.Interface;
using CardColode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardColode.Controller
{
    public class CardStorage
    {
        private Dictionary<string, Deck> decks;

        public CardStorage()
        {
            decks = new Dictionary<string, Deck>();
        }

        public void CreateDeck(string name)
        {
            if (decks.ContainsKey(name))
            {
                throw new InvalidOperationException("Колода с таким именем уже существует.");
            }

            // Создание стандартной колоды из 52 карт
            var deck = new Deck(name);
            var suits = new[] { Suit.Hearts, Suit.Diamonds, Suit.Clubs, Suit.Spades };
            var values = new[] { "Туз", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    deck.Cards.Add(new Card { Suit = suit, Value = value });
                }
            }

            decks.Add(name, deck);
        }

        public void RemoveDeck(string name)
        {
            if (!decks.ContainsKey(name))
            {
                throw new InvalidOperationException("Колода с таким именем не существует.");
            }

            decks.Remove(name);
        }

        public void ShuffleDeck(string name, ColodeShuffler_Controller shuffler)
        {
            if (!decks.ContainsKey(name))
            {
                throw new InvalidOperationException("Колода с таким именем не существует.");
            }

            var deck = decks[name];
            shuffler.Shuffle(deck.Cards);
        }

        public Deck GetDeck(string name)
        {
            if (!decks.ContainsKey(name))
            {
                throw new InvalidOperationException("Колода с таким именем не существует.");
            }

            return decks[name];
        }

        public List<string> GetDeckNames()
        {
            return new List<string>(decks.Keys);
        }
    }

}
