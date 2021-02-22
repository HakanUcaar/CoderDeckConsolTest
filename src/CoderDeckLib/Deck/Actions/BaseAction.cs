using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck.Actions
{
    public abstract class BaseAction  : IBaseAction
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TextPosition Position { get; set; }
        public string Image { get; set; }

        public abstract void ExecuteAction();
    }
}
