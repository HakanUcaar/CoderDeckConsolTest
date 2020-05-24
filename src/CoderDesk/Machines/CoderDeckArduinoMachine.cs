using CoderDeck.Machines.Movements;
using Dakota.Machine;

namespace CoderDeck.Machines
{
    public class CoderDeckArduinoMachine : AbstractMachine
    {
        public CoderDeckArduinoMachine() : base("1", "Coder Deck")
        {
            NewMovement<ButtonOnePushMovement>();
            NewMovement<ButtonTwoPushMovement>();
            NewMovement<ButtonThreePushMovement>();
            NewMovement<ButtonFourPushMovement>();
        }
    }
}
