using CoderDeckLib.Deck.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck
{
    public class KeyButton
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ActionType ActionType { get; set; }

        public IBaseAction Action { get; set; }
    }
}
