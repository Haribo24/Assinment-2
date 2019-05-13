using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoll : MonoBehaviour {

	public float BeginningForce;
	public Vector3 Origin;
	public float forceArea;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag ("canTrigger")) {
			if (col.GetComponent<Rigidbody> () != null) {
				col.GetComponent<Rigidbody> ().AddExplosionForce (BeginningForce, Origin, forceArea);
			}
		}
	}
}
