using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {

	public float max = 1f;
	public float speed = 5.0f;
	
	private SpriteRenderer sprite;

	void Start()
	{
	   sprite =	this.gameObject.GetComponent<SpriteRenderer>();
	}

	void Update () {
		sprite.color = new Color(1f, 1f, 1f, Mathf.PingPong(Time.time * speed, max));
	}
}
