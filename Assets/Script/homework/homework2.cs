//Homework2
//Write a function that uses a condition
//Write a for loop
//Write a dog class and initialize an instance of the class
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework2 : MonoBehaviour {
    public float rate = 0.1f;
    public float deposite = 100f;
    public List<string> monthnames = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov" };



    // Use this for initialization
    void Start() {
        homeworkClass SS = new homeworkClass();
        {
            Debug.Log(SS.balance + "/" + SS.Totalbalance);
            Debug.Log("balance " + SS.CurrentbalancePercent() + "%");
        }

    //  float balance = rate * deposite + deposite;
    //   if (balance > 110 || balance < 110)
    //   {
    //       Debug.Log("result is wrong " + balance);
    //  }
    //   else if (balance == 110)
    //   {
    //       Debug.Log("result is right " + balance);
    //   }
    // }



    // Update is called once per frame
    //void Update() {
        //{
        //int currentbalance = 5;
        //bool isInDebt = currentbalance <= 10;
        //{
        //  Debug.Log("isInDebt " + isInDebt);
        // if (isInDebt)
        //  Debug.Log("Enough balance");
        // }

        // }
        // LoopTest
        for (int i = 5; i <= 10; i++)
        {
            Debug.Log("bankbalance " + i);
        }
        for (int i = 10; i > -1; i--)
        {
            Debug.Log("bankbalance " + 1);
        }
        //foreach (string names in monthnames)
        //{
        //    Debug.Log(name);
        //}

    }
}


