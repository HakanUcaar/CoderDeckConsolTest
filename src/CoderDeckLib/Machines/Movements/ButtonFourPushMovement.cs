using Dakota.Machine;
using System;

namespace CoderDeckLib.Machines.Movements
{
    public class ButtonFourPushMovement : AbstractMovement
    {
        public ButtonFourPushMovement(IMachine Machine) : base(Machine, "Buton4Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            CoderDeck.RefreshActionInfo();
            if (CoderDeck.CurrentProfile.Buttons[3].Action != null)
            {
                CoderDeck.CurrentProfile.Buttons[3].Action.ExecuteAction();
            }
            //Keyboard.CtrlKeyStroke('K', 'U');
            //Console.WriteLine(Sender.Name + " Okunan Veri : Buton4Pushed");
        }
    }
}
