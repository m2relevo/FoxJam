using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour 
{


	public void DoorGone ()
	{

			this.GetComponent<MeshRenderer>().enabled = false;
			this.GetComponent<BoxCollider2D>().enabled = false;

	}

	public void DoorHere ()
	{
		this.GetComponent<MeshRenderer>().enabled = true;
		this.GetComponent<BoxCollider2D>().enabled = true;
	}
}
