using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck.Actions
{
    public class WebSiteAction : BaseAction
    {
        public string Website { get; set; }

        public override void ExecuteAction()
        {
            System.Diagnostics.Process.Start(Website);
        }
    }
}
