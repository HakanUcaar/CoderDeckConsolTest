using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck.Actions
{
    public class HotkeySwitchAction : BaseAction
    {
        public bool OnOff { get; set; }
        public HotKeyAction HotKey1 { get; set; }
        public HotKeyAction HotKey2 { get; set; }

        public override void ExecuteAction()
        {
            if (OnOff)  HotKey1.ExecuteAction(); else HotKey2.ExecuteAction();
        }
    }
}
