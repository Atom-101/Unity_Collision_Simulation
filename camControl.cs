//Script that moves camera to follow Object1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour {

	Transform o1; //transform of object1
	float offset;//offset distance between camera and object1

	void Start () {
		o1 = GameObject.FindWithTag ("O1").GetComponent<Transform> ();
		offset = o1.position.x - transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position =new Vector3( o1.position.x - offset,transform.position.y,transform.position.z);//updating position of camera every frame 
	}
}
