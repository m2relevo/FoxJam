using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
	
}

public class P1Movement : MonoBehaviour {
	private RigidBody2D P1character;
	public float speed = 1.0f;
	public Boundary bounds;
	// Use this for initialization
	void Start () 
	{
		P1character = this.rigidbody2D;
	}
	
   //use fixed update for physics based character
	void FixedUpdate()
	{
		float moveHorizontal = input.GetAxis ("Horizontal");
		float moveVertical = input.GetAxis ("Vertical");

		Vector2 movement = new Vector2(moveHorizontal,moveVertical);
		rigidbody.velocity = movement * speed * Time.deltaTime;

		rigidbody.position = new Vector2 
		(Mathf.Clamp (rigidbody2D.position.x, bounds.xMin, bounds.xMax),
		 Mathf.Clamp (rigidbody2D.positon.y, bounds.yMin, bounds.yMax));
	}
}

