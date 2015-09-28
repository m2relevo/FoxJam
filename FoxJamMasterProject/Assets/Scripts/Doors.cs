using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour 
{


	public void DoorGone ()
	{

			this.GetComponent<SpriteRenderer>().enabled = false;
			this.GetComponent<BoxCollider2D>().enabled = false;

	}

	public void DoorHere ()
	{
		this.GetComponent<SpriteRenderer>().enabled = true;
		this.GetComponent<BoxCollider2D>().enabled = true;
	}
}
