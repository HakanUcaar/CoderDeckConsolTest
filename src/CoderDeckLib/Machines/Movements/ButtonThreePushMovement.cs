using Dakota.Machine;
using System;

namespace CoderDeckLib.Machines.Movements
{
    public class ButtonThreePushMovement : AbstractMovement
    {
        public ButtonThreePushMovement(IMachine Machine) : base(Machine, "Buton3Pushed")
        {
            OnReceiveData += ReceiveData;
        }
        public void ReceiveData(IMachine Sender, object Data)
        {
            CoderDeck.RefreshActionInfo();
            if (CoderDeck.CurrentProfile.Buttons[2].Action != null)
            {
                CoderDeck.CurrentProfile.Buttons[2].Action.ExecuteAction();
            }
            
            //Keyboard.CtrlKeyStroke('K','C');
            //Console.WriteLine(Sender.Name + " Okunan Veri : Buton3Pushed");
        }
    }
}
