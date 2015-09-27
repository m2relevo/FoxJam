using UnityEngine;
using System.Collections;

public class ObstacleMove : MonoBehaviour {

	public bool interact;
	public bool perm;
	public GameObject obstacle;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" || other.tag == "Player2") 
		{
			if(perm == true)
			{
			   if(interact == false)
				{
					obstacle.GetComponent<Doors>().DoorGone();
				}
			}
		}
		if (perm == false) 
		{
			obstacle.GetComponent<Doors>().DoorGone();
		}
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if(interact == true && Input.GetKeyDown(KeyCode.E))
		{

				obstacle.GetComponent<Doors>().DoorGone();

		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player" || other.tag == "Player2")
		{
			if (perm == false) 
			{
				obstacle.GetComponent<Doors>().DoorHere();
			}
		}
	}
}
