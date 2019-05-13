using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRiged2 : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag ("Flipper 2"))
		{
			this.gameObject.SetActive (false);
			Debug.Log ("collide");
		}
	}
}
