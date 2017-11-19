using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework34 : MonoBehaviour {
    public Material[] materials;
    public Renderer rend;
    private int index = 1;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (materials.Length == 0)
        {
            return;
        }
        if (Input.GetKey(KeyCode.W))
            index += 1;
        else
        {
            I
        }
            

            if (index == materials.Length + 1)
            {
                index = 1;
            }



        }
        Debug.Log(index);
        rend.sharedMaterial = materials[index - 1];
    }
}

