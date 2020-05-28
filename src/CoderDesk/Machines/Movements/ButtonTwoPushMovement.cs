using Dakota.Machine;
using System;
using System.Windows.Forms;

namespace CoderDeck.Machines.Movements
{
    public class ButtonTwoPushMovement : AbstractMovement
    {
        public ButtonTwoPushMovement(IMachine Machine) : base(Machine, "Buton2Pushed")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            //SendKeys.SendWait("^V");
            Console.WriteLine(Sender.Name + " Okunan Veri : Buton2Pushed");            
        }
    }
}
