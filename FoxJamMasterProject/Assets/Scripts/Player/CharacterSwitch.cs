using UnityEngine;
using System.Collections;

public class CharacterSwitch : MonoBehaviour {


	public Camera cam1;
	public Camera cam2;
	public GameObject player1;
	public GameObject player2;
	bool playingC;

	// Use this for initialization
	void Start () 
	{
		cam1.enabled = true;
		cam2.enabled = false;
		playingC = false;
		player1.GetComponent<Player1>().enabled = true;
		player2.GetComponent<P2move>().enabled = false;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

			if (Input.GetKeyDown(KeyCode.LeftControl)) 
			{
				playingC = !playingC;
				playerSwitch (playingC);
			}
	}
	void playerSwitch(bool Switch)
	{
		if (Switch == true) 
		{
			player1.GetComponent<Player1>().enabled = false;
			player2.GetComponent<P2move>().enabled = true;
			cam1.enabled = false;
			cam2.enabled = true;
		}
		if (Switch == false) 
		{
			player1.GetComponent<Player1>().enabled = true;
			player2.GetComponent<P2move>().enabled = false;
			cam2.enabled = false;
			cam1.enabled = true;
		}
	}
}
