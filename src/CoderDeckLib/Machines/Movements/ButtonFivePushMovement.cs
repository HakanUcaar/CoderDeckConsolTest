using Dakota.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib.Machines.Movements
{
    public class ButtonFivePushMovement : AbstractMovement
    {
        public ButtonFivePushMovement(IMachine Machine) : base(Machine, "Buton5Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            CoderDeck.RefreshActionInfo();
            if (CoderDeck.CurrentProfile.Buttons[4].Action != null)
            {
                CoderDeck.CurrentProfile.Buttons[4].Action.ExecuteAction();
            }
            //Console.WriteLine(Sender.Name + " Okunan Veri : Buton5Pushed");
        }
    }
}
