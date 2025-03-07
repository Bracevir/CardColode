using CardColode.Interface;
using CardColode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardColode.Controller
{
    public class ColodeShuffler_Controller : IShuffler
    {
        private Random _random = new Random();

        public void Shuffle(List<Card> cards)
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
    }
}
