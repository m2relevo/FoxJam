using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public Transform Checkpointpos;
	private GameObject player;
	//private GameObject player2;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		//player = GameObject.FindGameObjectWithTag ("Player2");
	}

	
	void OnTriggerEnter2D (Collider2D other)
	{
	if (other.tag == "Player" || other.tag == "Player2") 
		{
				killPlayers ();
		}
	}

	void killPlayers()
	{

        if (Checkpointpos != null)
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
            //player2.GetComponent<SpriteRenderer>().enabled = false;
            player.transform.position = Checkpointpos.position;
            //player2.transform.position = Checkpointpos.position;
            player.GetComponent<SpriteRenderer>().enabled = true;
            //player2.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (Checkpointpos == null)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
	}
	public void Setcheckpoint(Transform newCheck)
	{
		Checkpointpos = newCheck.transform;

	}

}
