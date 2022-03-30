///////////////////////////////////////////////////////
// STM32 Pong Project - Léo Séry && Matthias Flament
// ####
// Script to retrieve data via the Serial port and convert them into decimal values.
// script by Léo Séry - 17/03/2022
// ####
/////////////////////////////////////////////////////// 
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ReadData : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM7", 115200);
        
    private string inputData;
    private string inputX;
    private string inputX2;

    public enum PlayerState {Up, Static, Down,}
    public string Player1_State;
    public string Player2_State;

    void Start()
    {
        stream.Open();
    }

    void Update()
    {
        inputData = stream.ReadLine();
        stream.BaseStream.Flush();
        string[] data = inputData.Split('|');

        if (data[0] != "" && data[2] != "")
        {
            inputX = data[0];
            inputX2 = data[2];
        }

        int xValue = int.Parse(inputX, System.Globalization.NumberStyles.HexNumber);
        int x2Value = int.Parse(inputX2, System.Globalization.NumberStyles.HexNumber);

        
        //Player 1
        if (xValue < 128)
        {
            Player1_State = PlayerState.Down.ToString();
        }
        else if (xValue > 128)
        {
            Player1_State = PlayerState.Up.ToString();
        }
        else
        {
            Player1_State = PlayerState.Static.ToString();
        }

        //Player 2
        if (x2Value < 128)
        {
            Player2_State = PlayerState.Down.ToString();
        }
        else if (x2Value > 128)
        {
            Player1_State = PlayerState.Up.ToString();
        }
        else
        {
            Player1_State = PlayerState.Static.ToString();
        }
    }
}
