using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadania : MonoBehaviour
{

    void Start()
    {
        //zadanie 1
        int a = 20;
        float b = 2.5f;

        //zadanie 2
        bool logiczny1 = true;
        bool logiczny2 = false;

        //zadanie 3
        string str = "Programuję w C#";
        string epg = "EPG";

        //zadanie 4
        Debug.Log("a: " + a + " b: " + b + " logiczny1: " + logiczny1 + " logiczny2: " + logiczny2);
        Debug.Log(str);
        Debug.Log(epg);

        //zadanie 5
        if (a == b)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }

        if (a <= b)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }

        if (a >= b)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }

        //zadanie 6

        if (string.Equals(str, epg))
        {
            Debug.Log("Takie same");
        }
        else
        {
            Debug.Log("różne");
        }

        //zadanie 8
        Koniunkcja(logiczny1, logiczny2);
        Alternatywa(logiczny1, logiczny2);
    }

        //zadanie 7
    public void Koniunkcja(bool logiczny1, bool logiczny2) 
    {
       

        if ((logiczny1 == true) && (logiczny2 == false))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

        
    public void Alternatywa(bool logiczny1, bool logiczny2)
    {

        if ((logiczny1 == true) || (logiczny2 == false))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }


    void Update()
    {
        
    }
}
