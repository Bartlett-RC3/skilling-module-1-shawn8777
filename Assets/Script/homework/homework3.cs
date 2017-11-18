/*Create a cube and move it across the screen
Create a cube and change its colour when key is pressed or mouse is pressed
Add a script to a game object*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework3 : MonoBehaviour
{
    public GameObject flyCube;
    bool moveLeft = true;
    bool moveRight = false;
    int counter = 0;
    public float movespeed;



    // Use this for initialization
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
        counter = counter + 2;
        if (counter % 2 == 0)
        {
            Debug.Log("Time in frames is: " + counter / 2);
        }
            Debug.Log("Actual time is: " + Time.deltaTime.ToString());
        {
            if (moveLeft == true)
            {
                if (counter <= 11)
                {
                    this.gameObject.GetComponent<Transform>().position = new Vector3(counter * (-1), 0, 0);
                    counter++;
                }

            }
            else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if (moveRight == true)
        {
            if (counter > 11)
            {
                gameObject.transform.Translate(Vector3.left);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 0;
            }
        }
        if (moveLeft == true)
        {
            if (counter <= 9)
            {
                gameObject.transform.Translate(Vector3.left);
                counter++;
            }
            else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
            if (moveRight == true)
            {
                if (counter > 9)
                {
                    gameObject.transform.Translate(Vector3.right);
                    counter++;
                }
                else
                {
                    moveLeft = true;
                    moveRight = false;
                    counter = 0;
                }
            }
        }
    }
}
    
