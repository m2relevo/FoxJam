using UnityEngine;
using System.Collections;

public class Collectables : MonoBehaviour 
{
    private bool alive;
	public float max = 1f;
	public float speed = 5.0f;	
	private SpriteRenderer sprite;
	public int pointvalue = 150;
	// Use this for initialization
	void Start () 
	{
        alive = true;
        sprite = this.GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update () 
	{
        if (alive == true)
        {
            sprite.color = new Color(1f, 1f, 1f, Mathf.PingPong(Time.time * speed, max));
        }
	}



	void OnTriggerEnter2D(Collider2D other)
	{
		ScoreManager.score += pointvalue;
		CollectManager.collect += 1;

		//renderer.gameObject.color.a = 0;
		if (other.tag == "Player") 
		{
			Destroy(gameObject);
            alive = false;
		}
	
	}
}
