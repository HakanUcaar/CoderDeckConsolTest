using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderDeck.WindowsService
{
    public abstract class BaseAction : IBaseAction
    {
        public string Name { get; set; }
        public NamePosition Position { get; set; }
        public string Image { get; set; }
    }
}
