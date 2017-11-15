// Session 2 : Conditionals, Loops and Classes 
// UCL RC3 12Nov2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour {

    // Variables 
    public int myNumber = 2;
    public bool questionTime = true;
    int myVariableQuestionTime;

    string[] fruits = { "banana", "apple", "mango", "blueburry" };


    // Use this for initialization
    void Start() {
        // Variable name is equal to either 1 or 0 based on the value of questionTime
        myVariableQuestionTime = (questionTime) ? 1 : 0;
        {
            Debug.Log("The value of myVariableQuestionTime is:" + myVariableQuestionTime);
        }
        // Question concatenation
        if (myNumber == 2 && questionTime == false)
        {
            Debug.Log("Your number is 2 and QT is false");
        }


        // Conditionals
        // Normal if statement
        if (myNumber == 2 || questionTime == false)
        {
            Debug.Log("Your number is equal to 2.");
        } else
        {
            Debug.Log("Your number is not equal to 2.");
        }
        // Short if statement
        if (questionTime)
        {
            Debug.Log("Question time is true.");
        } else
        {
            Debug.Log("Question time is false.");
        }
    }
        //Loops 
        Debug.Log("Fuirt in list at position 1 is: " + fruits[0]);
        Debug.Log("Fuirt in list at position 1 is: " + fruits[2]);
        // For loop statement (strat value, how this ends, incrementation)
        for (int i = 0; i < fruits.Length; i = i + 1)

       {
        Debug.Log("Fruits at position " + i + "is " + fruits[i]);
	    }

       
 


	// Update is called once per frame

	void Update () {
		
	}
    }
