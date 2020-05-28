﻿using Dakota.Machine;
using System;

namespace CoderDeck.Machines.Movements
{
    public class ButtonThreePushMovement : AbstractMovement
    {
        public ButtonThreePushMovement(IMachine Machine) : base(Machine, "Buton3Pushed")
        {
            OnReceiveData += ReceiveData;
        }
        public void ReceiveData(IMachine Sender, object Data)
        {
            //Keyboard.CtrlKeyStroke('K','C');
            Console.WriteLine(Sender.Name + " Okunan Veri : Buton3Pushed");
        }
    }
}
