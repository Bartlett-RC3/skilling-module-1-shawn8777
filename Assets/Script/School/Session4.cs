susing System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session4 : MonoBehaviour {

    // Variables
    public GameObject ColumnPrefab;
    IEnumerator CreatColumnCoroutine;

	// Use this for initialization
	void Start () {
        //creatColumnCoroutine = DropColumns();
        //float x = Random.Range(0, 100);
        //float x = UnityEngine.Random.Range(1, 10);
       
    }
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(CreatColumnCoroutine);
        Debug.Log(Time.time);

        if (Time.time > 5)
        {
            StopCoroutine(CreatColumnCoroutine);
            StopAllCoroutines();
        }
    }

    // Corountnes
    IEnumerator DropColumns()
    {
        while (true)
        {
            Vector3 columnPosition = new Vector3(Random.Range(-5f, 2.5f), Random.Range(8f, 15f), Random.Range(-7f, 4f));
            float x = Random.Range(0, 90);
            float y = Random.Range(0, 90);
            float z = Random.Range(0, 90);
            Quaternion columnRotation = new Quaternion(x, y, z, 1);
            GameObject newColumn = Instantiate(ColumnPrefab, columnPosition, columnRotation);
            yield return new WaitForSeconds(5);
        }
       
            
         

    }
}
