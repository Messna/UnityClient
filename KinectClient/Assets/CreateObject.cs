using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateObject : MonoBehaviour {

    public GameObject TestObject;
    public Client KinectClient;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 test = new Vector3(20, 0, 0);
		if (KinectClient.pointsDictionary.TryGetValue ("P1", out test)) {
			TestObject.transform.position = test;
			//Instantiate (TestObject, test, new Quaternion ());
		} 
    }
}
