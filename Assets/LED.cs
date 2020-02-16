﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class LED : MonoBehaviour
{
    public SerialPort serial = new SerialPort("COM 3", 9600);
    private bool lightState = false;
    
    public void onLed()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }
        serial.Write("A");
        lightState = true;
    }

    public void offLed()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }
        serial.Write("a");
        lightState = false;
    }
}