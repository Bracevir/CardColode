using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardColode.Model
{
    public class Card
    {
        public Suit Suit { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Value} {Suit}";
        }
    }

}
