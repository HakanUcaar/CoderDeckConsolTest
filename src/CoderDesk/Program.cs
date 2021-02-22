﻿using CoderDeck.Machines;
using Dakota.Receiver.SerialPort;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoderDeckLib;

namespace CoderDeck
{
    class Program
    {
        static void Main(string[] args)
        {

            CoderDeckLib.CoderDeck Deck = new CoderDeckLib.CoderDeck();
            var x = Deck.Connect("").Result;

            //var Receiver = new SerialPortReceiver(new CoderDeckArduinoMachine());
            //Receiver.PortName = "COM3";
            //Receiver.BaudRate = 9600;
            //Receiver.Parity = Parity.None;
            //Receiver.DataBits = 8;
            //Receiver.StopBits = StopBits.One;
            //Receiver.Handshake = Handshake.None;
            //Receiver.Connect();

            Console.ReadLine();
        }
    }
}
