using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework34 : MonoBehaviour
{
    public Material[] materials;
    public Renderer rend;
    
    

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rend.sharedMaterial = materials[0];
        }
        if (Input.GetKey(KeyCode.A))
        {
            rend.sharedMaterial = materials[1];
        }
        if (Input.GetKey(KeyCode.S))
        {
            rend.sharedMaterial = materials[2];
        }
        if (Input.GetKey(KeyCode.D))
        {
            rend.sharedMaterial = materials[3];
        }
    }


}

