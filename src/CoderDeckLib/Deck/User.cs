using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public Profile CurrentProfile { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}
