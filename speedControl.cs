//Script to add initial velocity and forces to both objects
//Since mass of both bodies is 1, F=a

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedControl : MonoBehaviour {

	Rigidbody o1,o2;//reference to rigidbodies of object1 and object2


	void Start () 
	{
		o1 = GameObject.FindWithTag("O1").GetComponent<Rigidbody>();
		o2 = GameObject.FindWithTag("O2").GetComponent<Rigidbody>();
		//Setting initial velocities of each object
		o1.velocity = new Vector3 (1, 0, 0);
		o2.velocity = new Vector3 (19, 0, 0);
		
	}
	
	void FixedUpdate () 
	{
		//Adding forces to the objects to obtain the required acceleration 
		o1.AddForce (new Vector3 (17, 0, 0));
		o2.AddForce (new Vector3 (3, 0, 0));
		
	}
}
