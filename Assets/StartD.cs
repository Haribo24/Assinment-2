using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartD : MonoBehaviour {

		void Start ()
		{

		}

		void Update ()
		{
		if(Input.GetKeyDown(KeyCode.Space))
			this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 200.0f);
		}

}