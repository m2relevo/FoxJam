using UnityEngine;
using System.Collections;

public class Pausemenu : MonoBehaviour

{
	public GameObject Pause;
	private bool paused = false;

	void start ()
	{
		Pause.SetActive (false);
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape) & paused == false) 
		{
			Pause.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.Escape) & paused == true)
		{
			Pause.SetActive (false);
		}
	}

/*
	void update()
	{
		if (Input.GetButtonDown ("Pause"))
		{
			paused = ! paused;
	
		}
	
		if (paused)
		{
			Pause.SetActive(true);
			//Time.timescale = 0;
		}

		if (!paused)
		{
			Pause.SetActive(false);
			//Time.timescale = 1;
		}
	}
	*/
}
