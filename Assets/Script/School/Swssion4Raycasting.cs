using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swssion4Raycasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Ray direction
        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);

        //Store the object that is in front

        RaycastHit objectInFornt;

        //Ray casting

        if (Physics.Raycast(transform.position, castedRayDirection, out objectInFornt))
        {
            string objectInFrontName = objectInFornt.transform.name;
            Debug.Log("There is an object fornt of me! " + objectInFornt);
        }
        //Move the cube up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 0.01f);
        }
        //Move the cube down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up);
        }

    }
}
