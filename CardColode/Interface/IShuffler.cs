using CardColode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardColode.Interface
{
    public interface IShuffler
    {
        void Shuffle(List<Card> cards);
    }

}
