using Dakota.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeck.Machines.Movements
{
    public class ButtonFivePushMovement : AbstractMovement
    {
        public ButtonFivePushMovement(IMachine Machine) : base(Machine, "Buton5Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            Console.WriteLine(Sender.Name + " Okunan Veri : Buton5Pushed");
        }
    }
}
