using Dakota.Machine;
using System;

namespace CoderDeck.Machines.Movements
{
    public class ButtonFourPushMovement : AbstractMovement
    {
        public ButtonFourPushMovement(IMachine Machine) : base(Machine, "Buton4Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            //Keyboard.CtrlKeyStroke('K', 'U');
            Console.WriteLine(Sender.Name + " Okunan Veri : Buton4Pushed");
        }
    }
}
