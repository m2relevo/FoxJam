using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	private Player1 player;

	void Start()
	{
		player = gameObject.GetComponentInParent <Player1> ();
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		player.grounded = true;
	}

	void OnTriggerStay2D(Collider2D col)
	{
		player.grounded = true;
	}

	void OnTriggerExit2D(Collider2D col)
	{
		player.grounded = false;
	}
}
