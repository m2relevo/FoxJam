using UnityEngine;
using System.Collections;

public class P1move : MonoBehaviour {
	
	public float movSpeed = 10f;
	bool facingRight = true;
	
	Animator anime;
	Rigidbody2D myRig;
	
	// Use this for initialization
	void Start ()
	{
		anime = GetComponent<Animator>();
		myRig = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		float move = Input.GetAxis("Horizontal");
		
		myRig.velocity = new Vector2(move * movSpeed, myRig.velocity.y);
		
		if (move > 0 && !facingRight)
			Flip();
		else if (move < 0 && facingRight)
			Flip();
	}
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 myScale = transform.localScale;
		myScale.x = -1;
		transform.localScale = myScale;
	}
}