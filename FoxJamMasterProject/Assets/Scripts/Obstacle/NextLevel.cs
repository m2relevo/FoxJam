using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour 
{
	public string NLevel;

	 void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" || other.tag == "Player2")
			Application.LoadLevel (NLevel);

	}

}
