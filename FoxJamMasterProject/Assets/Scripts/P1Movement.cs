/*using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
	
}

public class P1Movement : MonoBehaviour {
	private Rigidbody2D P1character;
	public float speed = 1.0f;
	public Boundary bounds;
	// Use this for initialization
	void Start () 
	{
		P1character = this.Rigidbody2D;
	}
	
   //use fixed update for physics based character
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2(moveHorizontal,moveVertical);
		Rigidbody.velocity = movement * speed * Time.deltaTime;

		Rigidbody.position = new Vector2 
		(Mathf.Clamp (Rigidbody2D.position.x, bounds.xMin, bounds.xMax),
		 Mathf.Clamp (Rigidbody2D.position.y, bounds.yMin, bounds.yMax));
	}
}

*/