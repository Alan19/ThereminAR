using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    public static string Key = "C";
    public static string Note = "";
    public static string Instrument = "Flute";
    public static int Tempo = 130;

    internal static string getSetting(string setting)
    {
        switch (setting)
        {
            case "key":
                return Key;
            case "note":
                return Note;
            case "instrument":
                return Instrument;
            case "tempo":
                return Tempo.ToString();
            default:
                return "Not found";
        }
    }

    internal static void changeSetting(string fieldToChange, int amount)
    {
        Debug.Log("Changed setting " + fieldToChange + " by " + amount);
        switch (fieldToChange)
        {
            case "key":
                if(Key.Equals("C") && amount == 1)
                {
                    Key = "D";
                }
                else if(Key.Equals("D") && amount == -1)
                {
                    Key = "C";
                }
                break;
            case "instrument":
                if (Instrument.Equals("Flute") && amount == 1)
                {
                    Instrument = "Piano";
                }
                else if (Instrument.Equals("Piano") && amount == -1)
                {
                    Instrument = "Flute";
                }
                break;
            case "tempo":
                Tempo += amount;
                break;
        }
    }
}
