 

Module Module1

 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.IO.Ports;

    Sub Main()

 namespace ConsoleApplication1
 {
        Class Program
 {
 static void Main(string[] args)
 {
 SerialPort port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);

 port.Open();
 port.Write("1"); port.Close();}
}
}

    End Sub

End Module
