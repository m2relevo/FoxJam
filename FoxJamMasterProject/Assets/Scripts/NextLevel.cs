using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour 
{
	public string NLevel;

	 void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			Application.LoadLevel (NLevel);

	}

}
