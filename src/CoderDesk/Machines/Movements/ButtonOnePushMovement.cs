using Dakota.Machine;
using System;

namespace CoderDeck.Machines.Movements
{
    public class ButtonOnePushMovement : AbstractMovement
    {
        public ButtonOnePushMovement(IMachine Machine) : base(Machine, "Buton1Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            Keyboard.CtrlKeyStroke('C');
            Console.WriteLine(Sender.Name + " Okunan Veri : Buton1Pushed");
        }
    }
}
