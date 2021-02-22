using Dakota.Machine;
using System;

namespace CoderDeckLib.Machines.Movements
{
    public class ButtonTwoPushMovement : AbstractMovement
    {
        public ButtonTwoPushMovement(IMachine Machine) : base(Machine, "Buton2Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            CoderDeck.RefreshActionInfo();
            if (CoderDeck.CurrentProfile.Buttons[1].Action != null)
            {
                CoderDeck.CurrentProfile.Buttons[1].Action.ExecuteAction();
            }
            //Keyboard.CtrlKeyStroke('V');
            //Console.WriteLine(Sender.Name + " Okunan Veri : Buton2Pushed");            
        }
    }
}
