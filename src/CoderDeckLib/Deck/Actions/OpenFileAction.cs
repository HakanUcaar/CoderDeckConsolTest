using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Deck.Actions
{
    public class OpenFileAction : BaseAction
    {
        public string FilePath { get; set; }

        public override void ExecuteAction()
        {
            System.Diagnostics.Process.Start(FilePath);
        }
    }
}
