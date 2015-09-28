using UnityEngine;
using System.Collections;

public class AppearSwitch : MonoBehaviour
{
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
            if (perm == true)
            {
                if (interact == false && change == true)
                {

                    obstacle.GetComponent<Doors>().DoorHere();
                    this.GetComponent<SpriteRenderer>().sprite = End;          //permanent change no interact
                }
            }
        }

        if (perm == false)
        {
            if (interact == false && change == false)
            {
                obstacle.GetComponent<Doors>().DoorHere();                      //Temporary no change no interact
            }
            if (interact == false && change == true)
            {
                obstacle.GetComponent<Doors>().DoorHere();
                this.GetComponent<SpriteRenderer>().sprite = End;              //Temporary  change no interact
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (interact == true && Input.GetKeyDown(KeyCode.E))
        {
            if (change == true)
            {
                obstacle.GetComponent<Doors>().DoorHere();
                this.GetComponent<SpriteRenderer>().sprite = End;            //Interactable change perm
            }
            if (change == false)
            {
                obstacle.GetComponent<Doors>().DoorHere();                   //interactable no change perm
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
                if (change == false)
                {
                    obstacle.GetComponent<Doors>().DoorGone();
                }
            }
        }
    }
}
    