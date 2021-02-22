using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<KeyButton> Buttons { get; set; }
        public Profile()
        {
            Buttons = new List<KeyButton>();
        }
    }
}
