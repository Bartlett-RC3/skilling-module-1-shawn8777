//Homework 1
//Declare a int variable and set a value
//Declare a float variable and set a value
//Declare a string variable and set a value
//Create a function that prints the declared variables
//Declare and initialize an array
//Declare and initialize a list
//Create and initialize a Dictionary.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework1 : MonoBehaviour {
    
    //Variables
    public int Visacardbalance = 30;
    public int bankfixedtermrate = 2;
    public float currentbankrate = 0.85f;

    public string[] months = new string[12];

    public List<string> monthnames = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov" };

    public Dictionary<string, string> banknames = new Dictionary<string, string>();

    // Use this for initialization
    void Start () {
        //months[0] = "Jan";
        //months[1] = "Feb";
        //months[2] = "Mar";
        //months[3] = "Apr";
        //months[4] = "May";
        //months[5] = "Jun";
        //months[6] = "Jul";
        //months[7] = "Aug";
        //months[8] = "Sep";
        //months[9] = "Oct";
        //months[10] = "Nov";
        //months[11] = "Dec";


        // monthnames.Add("Dec");
        banknames.Add("paper1", "Barclays");


        

        {
            //Debug.Log("First month " + months[0]);
            //Debug.Log("Second month " + months[1]);
            // Debug.Log("Third month " + months[2]);
            //Debug.Log("Fourth month " + months[3]);
            // Debug.Log("Fifth month " + months[4]);
            //Debug.Log("Sixth month " + months[5]);
            //Debug.Log("Seventh month " + months[6]);
            //Debug.Log("Eighth month " + months[7]);
            // Debug.Log("Ninth month " + months[8]);
            //Debug.Log("Tenth month " + months[9]);
            //Debug.Log("Eleventh month " + months[10]);
            //Debug.Log("Twelfth month " + months[11]);


            //  Debug.Log("Total Monthname " + monthnames.Count);
            //  Debug.Log("First monthname " + monthnames[0]);
            //  Debug.Log("Last monthname " + monthnames[monthnames.Count-1]);

            Debug.Log("bankname in paper1 " + banknames["paper1"]);
            Debug.Log("paper2 filled " + banknames.ContainsKey("paper2"));
        }
    }
	
	// Update is called once per frame
	void Update () {
        //Visacardbalance = Visacardbalance * bankfixedtermrate;
        //{
        //    Debug.Log(Visacardbalance);
        //}
        //if (Visacardbalance > 0); 
         


    }
}
