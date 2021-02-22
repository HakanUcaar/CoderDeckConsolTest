using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck.Actions
{
    public class HotKeyAction : BaseAction
    {
        public bool CtrlKey { get; set; }
        public bool AltKey { get; set; }
        public bool Shiftkey { get; set; }
        public List<char> Keys { get; set; }

        public override void ExecuteAction()
        {
            Keyboard.KeyStroke(CtrlKey, AltKey, Shiftkey, Keys.ToArray());
        }
    }
}
