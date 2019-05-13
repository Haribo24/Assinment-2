using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;



	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (GameIsPaused) 
			{
				PauseMenuUI.SetActive (true);
				Time.timeScale = 0f;
				GameIsPaused = true;
			}
		}
	}
		
}