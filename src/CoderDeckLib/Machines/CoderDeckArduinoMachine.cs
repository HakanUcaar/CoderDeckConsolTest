using CoderDeckLib.Machines.Movements;
using Dakota.Machine;

namespace CoderDeckLib.Machines
{
    public class CoderDeckArduinoMachine : AbstractMachine
    {
        public CoderDeckArduinoMachine() : base("1", "Coder Deck")
        {
            NewMovement<ButtonOnePushMovement>();
            NewMovement<ButtonTwoPushMovement>();
            NewMovement<ButtonThreePushMovement>();
            NewMovement<ButtonFourPushMovement>();
            NewMovement<ButtonFivePushMovement>();
            NewMovement<ButtonSixPushMovement>();
        }
    }
}
