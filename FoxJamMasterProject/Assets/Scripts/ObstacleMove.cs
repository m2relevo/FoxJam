using UnityEngine;
using System.Collections;

public class ObstacleMove : MonoBehaviour {

	public bool interact;
	public bool perm;
    public bool change;
	public GameObject obstacle;
    private Sprite start;
    public Sprite End;

    void Start()
    {
        start = this.GetComponent<SpriteRenderer>().sprite;
    }

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" || other.tag == "Player2") 
		{
			if(perm == true)
			{
			   if(interact == false)
				{
                    if (change == true)
                    {
                        obstacle.GetComponent<Doors>().DoorGone();
                        this.GetComponent<SpriteRenderer>().sprite = End;
                    }
				}
			}
		}
		if (perm == false) 
		{
            if (change == true)
            {
                obstacle.GetComponent<Doors>().DoorGone();
                this.GetComponent<SpriteRenderer>().sprite = End;
            }
            
		}
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if(interact == true && Input.GetKeyDown(KeyCode.E))
		{
            if (change == true)
            {
                obstacle.GetComponent<Doors>().DoorGone();
                this.GetComponent<SpriteRenderer>().sprite = End;
            }

		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player" || other.tag == "Player2")
		{
			if (perm == false) 
			{
                if (change == true)
                {
                    obstacle.GetComponent<Doors>().DoorGone();
                    this.GetComponent<SpriteRenderer>().sprite = start;
                }
			}
		}
	}
}
