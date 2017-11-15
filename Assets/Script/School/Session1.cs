using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1 : MonoBehaviour
{

    public string text = "Hello world";
    public bool turnon = true;
    public float posX = 5.0f;
    public int intText = 5;

    // Use this for initialization
    void Start()
    {
        text = Text("Calling Test()"); //"Update during start()";

        print ("Hello world " + intText + " " + posX);

        





    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string Text(string value)
   {
    return value + " Update during Text()";
   }
}



