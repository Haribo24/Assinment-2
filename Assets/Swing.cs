using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour {

	public GameObject ball;
	public float speed = 5.0f;
	bool startTransform = false;


	void OnCollisionEnter(Collision col)
	{
		if (col.transform.tag == "Domino" && startTransform == false) 
		{
			startTransform = true;
			Debug.Log ("Start Moving");
		}
		else if (col.transform.tag == "Ball2" && startTransform == true) 
		{
			startTransform = false;
			Debug.Log ("Stop Moving");
		}

	}

	void Update()
	{
		if (startTransform == true) 
		{
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}

	}
}
