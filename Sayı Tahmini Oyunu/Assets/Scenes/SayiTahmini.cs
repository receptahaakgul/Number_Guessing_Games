using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayiTahmini : MonoBehaviour
{

    int max;
    int min;
    int tahmin;

    // Use this for initialization
    void Start()
    {
        OyunaBasla();
    }

    // Encapsulation - Kapsülleme
    void OyunaBasla()
    {
        max = 1500;
        min = 1;
        tahmin = 750;
        Debug.Log("Number guessing game starting...");
        Debug.Log("Think of a number and don't tell me.");
        Debug.Log("Your number shouldn't exceed " + max + ".");
        Debug.Log("Your number shouldn't be below " + min + ".");
        Debug.Log("Is your number " + tahmin + "?");
        Debug.Log("If your number is higher than my guess, press the Up arrow; if lower, press the Down arrow. " +
            "If my guess is correct, press Enter!");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = tahmin;
            SonrakiTahmin();
            Debug.Log("My guess is: " + tahmin + ". Should I guess higher or lower?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = tahmin;
            SonrakiTahmin();
            Debug.Log("My guess is: " + tahmin + ". Should I guess higher or lower?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I won! The computer is the master!");
            OyunaBasla();
        }
    }

    void SonrakiTahmin()
    {
        tahmin = (min + max) / 2;
    }
}
