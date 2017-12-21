//Script attached to Object1 that measures difference in time between start of scene and time of collision
//It also displays calculated time on screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeCount : MonoBehaviour {
	
	float t;//Time in s from beginning of scene to moment of collision 
	Text b;// reference to text box where calculated time is displayed

	void Start () {
		t = Time.time;
		b = GameObject.Find("Text").GetComponent<Text>();
	}

	void OnCollisionEnter(Collision c)
	{
		if (c.collider.CompareTag ("O2"))//checking for collision 
		{
			t = Time.time-t;//calculating time difference
			b.text = "Time: " + t.ToString ();
		}
	}
}
