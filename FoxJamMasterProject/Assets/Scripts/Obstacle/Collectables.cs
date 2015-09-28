using UnityEngine;
using System.Collections;

public class Collectables : MonoBehaviour 
{
	public float max = 1f;
	public float speed = 5.0f;	
	public SpriteRenderer sprite;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		sprite.color = new Color(1f, 1f, 1f, Mathf.PingPong(Time.time * speed, max));
	}



	void OnTriggerEnter2D(Collider2D other)
	{
		ScoreManager.score = + 100;
		//renderer.gameObject.color.a = 0;
		if (other.tag == "Player") 
		{
			Destroy(gameObject);
		}
	
	}
}
