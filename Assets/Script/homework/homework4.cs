/*Session 4 homework:
Create a cube prefab that has a script attached to it
Write a change colour coroutine
Create a cube array and change destroy them in play mode using ray casting*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework4 : MonoBehaviour
{

    public Material[] materials;
    public Renderer rend;
    public float movespeed = 0.01f;


    // Use this for initialization
    void Start()
    {
       
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("ColorchangingCoroutine", 0.3f);
        Debug.Log(Time.time);
        
        if (Time.time > 5)
        {
            gameObject.transform.Translate(0, 0, 0);
            StopCoroutine("ColorchangingCoroutine");
            StopAllCoroutines();
            rend.sharedMaterial = materials[2];
            Debug.Log("yellow " + " " + "ColorchangingCoroutine has been stoped");
            gameObject.transform.Translate(0, 0, 0);
        }
    }

    IEnumerator ColorchangingCoroutine(float waitTime)
    {
        for (float i = 3.6f; i > waitTime; i = i - 0.6f)
        { 
        rend.sharedMaterial = materials[0];
            gameObject.transform.Translate(0.1f, 0, 0);
        Debug.Log("blue" + Time.time);
        
        yield return new WaitForSeconds(waitTime);
        rend.sharedMaterial = materials[1];
            gameObject.transform.Translate(-0.1f, 0, 0);
        Debug.Log("red" + Time.time);

            
        }
            
           
    }
}




