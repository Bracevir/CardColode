using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardColode.Model
{
    public class Deck
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string name)
        {
            Name = name;
            Cards = new List<Card>();
        }

        public override string ToString()
        {
            var cardsString = string.Join(Environment.NewLine, Cards);
            return $"Колода: {Name}{Environment.NewLine}{cardsString}";
        }
    }
}
