using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

	public GameObject Door;
	public bool DoorIsOpening;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (DoorIsOpening == true) {
			Door.transform.Translate (Vector3.up * Time.deltaTime * 30);
		}
		if (Door.transform.position.y > 90f) {
			DoorIsOpening = false;
		}
	}
	void OnCollisionEnter (Collision col)
	{
		DoorIsOpening = true;

	}
}
