using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip2 : MonoBehaviour {

	public GameObject flipper;
	public float speed = 5.0f;
	bool startRotating = false;


	void OnCollisionEnter(Collision col)
	{
		if (col.transform.tag == "Ball" && startRotating == false) 
		{
			startRotating = true;
			Debug.Log ("Start Rotating");
		}
		else if (col.transform.tag == "Ball" && startRotating == true) 
		{
			startRotating = false;
			Debug.Log ("Stop Rotating");
		}
	}

	void Update()
	{
		if (startRotating == true) 
		{
			transform.RotateAround (flipper.transform.position, Vector3.forward, speed * Time.deltaTime);
		}
	}
}
