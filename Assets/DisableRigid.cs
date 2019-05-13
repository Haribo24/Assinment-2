using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRigid : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag ("Flipper"))
		{
			this.gameObject.SetActive (false);
			Debug.Log ("collide");
		}
	}
}
