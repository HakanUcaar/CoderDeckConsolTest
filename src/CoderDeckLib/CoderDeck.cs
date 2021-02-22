using CoderDeckLib.Deck;
using CoderDeckLib.Deck.Actions;
using CoderDeckLib.Machines;
using Dakota.Receiver.SerialPort;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDeckLib
{
    public class Startup
    {
        public static Profile CurrentProfile = new Profile()
        {
            Id = Guid.Parse("DC517D3C-6705-4048-9EA4-B35DD93BC01F"),
            Name = "HakoBako"
        };

        public async Task<object> Invoke(dynamic input)
        {
            var KeyButtons = JsonConvert.DeserializeObject<List<KeyButton>>(File.ReadAllText(@"KeyButtons.json"));
            CurrentProfile.Buttons = KeyButtons;

            var Receiver = new SerialPortReceiver(new CoderDeckArduinoMachine());
            Receiver.PortName = "COM3";
            Receiver.BaudRate = 9600;
            Receiver.Parity = Parity.None;
            Receiver.DataBits = 8;
            Receiver.StopBits = StopBits.One;
            Receiver.Handshake = Handshake.None;
            return Receiver.Connect();
        }
    }

    public class CoderDeck
    {
        public static Profile CurrentProfile = new Profile()
        {
            Id = Guid.Parse("DC517D3C-6705-4048-9EA4-B35DD93BC01F"),
            Name = "HakoBako"
        };

        public async Task<object> Connect(string input)
        {
            var KeyButtons = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText("KeyButtons.json"));
            GetActions(KeyButtons);
            var SerialInfo = JsonConvert.DeserializeObject<SerialPortInfoModel>(input);

            var Receiver = new SerialPortReceiver(new CoderDeckArduinoMachine());
            Receiver.PortName = SerialInfo.PortName;
            Receiver.BaudRate = SerialInfo.BaudRate;
            Receiver.Parity = SerialInfo.Parity;
            Receiver.DataBits = 8;
            Receiver.StopBits = StopBits.One;
            Receiver.Handshake = Handshake.None;
            return Receiver.Connect();           
        }

        public async Task<object> Refresh(dynamic input)
        {
            var KeyButtons = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText("KeyButtons.json"));
            GetActions(KeyButtons);
            return true;
        }

        public static void RefreshActionInfo()
        {
            var Buttons = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText("KeyButtons.json"));
            CurrentProfile.Buttons.Clear();
            foreach (var item in Buttons)
            {
                JObject Button = item as JObject;
                var KeyButton = new KeyButton();
                KeyButton.Id = Button.Value<int>("Id");
                KeyButton.Name = Button.Value<string>("Name");

                switch (Button.Value<string>("ActionType"))
                {
                    case "1": KeyButton.Action = Button.Value<JObject>("Action").ToObject<HotKeyAction>(); break;
                    case "2": KeyButton.Action = Button.Value<JObject>("Action").ToObject<HotkeySwitchAction>(); break;
                    case "3": KeyButton.Action = Button.Value<JObject>("Action").ToObject<WebSiteAction>(); break;
                    case "4": KeyButton.Action = Button.Value<JObject>("Action").ToObject<OpenFileAction>(); break;
                    case "5": KeyButton.Action = Button.Value<JObject>("Action").ToObject<MultimediaAction>(); break;
                    default:
                        break;
                }
                CurrentProfile.Buttons.Add(KeyButton);
            }
        }

        private void GetActions(List<object> Buttons)
        {
            foreach (var item in Buttons)
            {
                JObject Button = item as JObject;
                var KeyButton = new KeyButton();
                KeyButton.Id = Button.Value<int>("Id");
                KeyButton.Name = Button.Value<string>("Name");

                switch (Button.Value<string>("ActionType"))
                {
                    case "1": KeyButton.Action = Button.Value<JObject>("Action").ToObject<HotKeyAction>(); break;
                    case "2": KeyButton.Action = Button.Value<JObject>("Action").ToObject<HotkeySwitchAction>(); break;
                    case "3": KeyButton.Action = Button.Value<JObject>("Action").ToObject<WebSiteAction>(); break;
                    case "4": KeyButton.Action = Button.Value<JObject>("Action").ToObject<OpenFileAction>(); break;
                    case "5": KeyButton.Action = Button.Value<JObject>("Action").ToObject<MultimediaAction>(); break;
                    default:
                        break;
                }
                CurrentProfile.Buttons.Add(KeyButton);
            }
        }
    }
}
