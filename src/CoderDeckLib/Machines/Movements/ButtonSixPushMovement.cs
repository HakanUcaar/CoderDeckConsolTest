using Dakota.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Machines.Movements
{
    public class ButtonSixPushMovement : AbstractMovement
    {
        public ButtonSixPushMovement(IMachine Machine) : base(Machine, "Buton6Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            CoderDeck.RefreshActionInfo();
            if (CoderDeck.CurrentProfile.Buttons[5].Action != null)
            {
                CoderDeck.CurrentProfile.Buttons[5].Action.ExecuteAction();
            }
            //Console.WriteLine(Sender.Name + " Okunan Veri : Buton6Pushed");
        }
    }
}
