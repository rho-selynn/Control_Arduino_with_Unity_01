using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class LED : MonoBehaviour
{
    public SerialPort serial = new SerialPort("COM3", 9600);
    // Need the port and the baud rate
    private bool lightState = false;
    
    public void onLed()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }
        serial.Write("A");
        // Sends "A" to the Arduino
        lightState = true;
    }

    public void offLed()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }
        serial.Write("a");
        // Sends "a" to the Arduino
        lightState = false;
    }
}
