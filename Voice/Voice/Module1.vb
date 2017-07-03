using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

Namespace ConsoleApplication1
{
    Class Program
    {
        static void Main(string[] args)
        {
            SerialPort port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One); //Change COM5 to your com.
            port.Open();
            port.Write("1"); //the data that will be sent to the arduino, change if it is needed.
            port.Close();

        }
    }
}