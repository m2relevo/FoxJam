using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float CountDown;
    public GameObject Obstacle;
    private bool Here;


 
	// Update is called once per frame
	void Update ()
    {
        CountDown -= Time.deltaTime;
        if(CountDown < 0)
        {
            if (Here == true)
            {
                Obstacle.GetComponent<Doors>().DoorGone();
            }
            if (Here == false)
            {
                Obstacle.GetComponent<Doors>().DoorHere();
            }
        }	
	}
}
