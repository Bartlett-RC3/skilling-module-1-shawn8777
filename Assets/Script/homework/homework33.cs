using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework33 : MonoBehaviour {
    public GameObject cube;
    public float movespeed;
    public Material[] materials;
    public Renderer rend;
    private int index = 1;

	// Use this for initialization
	void Start () {
        movespeed = 7f;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
    private void OnMouseDown()
    {
        if (materials.Length == 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            index += 1;

        if(index == materials.Length + 1) 
            {
                index = 1;
            }

           

        }
        Debug.Log(index);
        rend.sharedMaterial = materials[index - 1];
    }
}
