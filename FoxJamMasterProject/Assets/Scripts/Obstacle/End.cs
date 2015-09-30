using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {
	
	public Transform Checkpointpos;
	private GameObject player;
	private GameObject player2;
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		player2 = GameObject.FindGameObjectWithTag ("Player2");
	}
	
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player" || other.tag == "Player2") 
		{
			Application.LoadLevel ("Main Menu");
		}
	}
}
