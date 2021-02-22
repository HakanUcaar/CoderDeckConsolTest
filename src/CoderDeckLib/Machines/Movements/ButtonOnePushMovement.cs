using Dakota.Machine;
using System;

namespace CoderDeckLib.Machines.Movements
{
    public class ButtonOnePushMovement : AbstractMovement
    {
        public ButtonOnePushMovement(IMachine Machine) : base(Machine, "Buton1Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            CoderDeck.RefreshActionInfo();
            if (CoderDeck.CurrentProfile.Buttons[0].Action != null)
            {
                CoderDeck.CurrentProfile.Buttons[0].Action.ExecuteAction();
            }
            //Keyboard.CtrlKeyStroke('C');
            //Console.WriteLine(Sender.Name + " Okunan Veri : Buton1Pushed");
        }
    }
}
