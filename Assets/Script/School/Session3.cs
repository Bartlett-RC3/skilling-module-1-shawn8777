using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3 : MonoBehaviour {

    // Variables 
    int counter = 0;
    public GameObject cubeReference;
    bool moveLeft = true;
    bool moveRight = false;

    // Use this for initialization
    void Start() { 
    /*
         * for (int i = 0; i < 10000; i++)

        {
            Vector3 cubePosition = new Vector3 (i + 0.5f, 0, 0);
            //rotation defined as no rotation
            Quaternion cubeRotation = Quaternion.identity;
            GameObject newCube = Instantiate(cubeReference, cubePosition, cubeRotation);
        }
       */
	}
	
	// Update is called once per frame
	void Update () {
        // Time in frame not very useful, because of the variation
        
        counter = counter + 1;
        if(counter%30 == 0)
        {
            Debug.Log("Time in frames is: " + counter/30 );
        }
        // Debug.Log("Frame: " + counter);
        Debug.Log("Actual time is :" + Time.deltaTime.ToString());
       

        //Move cube left and right by manually setting the Transform the values
        if (moveLeft == true)
        {
            if (counter <= 15)
            {
                // this refers to the script [we are in]
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter * (-1), 0, 0);
            
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
            this.gameObject.GetComponent<Transform>().position = new Vector3(counter, 0, 0);
        }
        else
        {
            moveRight = false;
            moveLeft = true;
            counter ++;
        }

	}

    // Move cube left and rigt;

   
        

    
        
}
