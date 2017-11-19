using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework33 : MonoBehaviour {
    public GameObject cube;
    public float movespeed;
    public Material[] materials;
    public Renderer rend;
    

	// Use this for initialization
	void Start () {
        movespeed = 7f;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
    }
	
	// Update is called once per frame
	
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
        gameObject.transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
        
    }
}
