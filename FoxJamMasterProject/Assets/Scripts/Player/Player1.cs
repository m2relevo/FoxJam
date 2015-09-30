using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {
	
	public float maxSpeed = 3;
	public float speed = 50f;
	public float jumpPower = 200f;
	public bool facingRight = true;
	
	public bool grounded;
	
	private Rigidbody2D rb2d;
	private Animator anim;
	
	// Use this for initialization
	void Start () 
	{
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		anim.SetBool ("Grounded", grounded);
		anim.SetFloat ("Speed", Mathf.Abs(rb2d.velocity.x));
		if (Input.GetButtonDown ("Jump") && grounded)
		{
			rb2d.AddForce(Vector2.up * jumpPower);
		}
		if (Input.GetButtonDown ("Jump")) 
		{

		}
	}
	
	void FixedUpdate()
	{
		Vector3 easeVelocity = rb2d.velocity;
		easeVelocity.y = rb2d.velocity.y;
		easeVelocity.z = 0.0f;
		easeVelocity.x *= 0.75f;

		if (grounded) 
		{
			rb2d.velocity = easeVelocity;
		}

		float h = Input.GetAxis ("Horizontal");
		
		rb2d.AddForce((Vector2.right * speed) * h);
		
		if (rb2d.velocity.x > maxSpeed)
		{
			rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
		}
		
		if (rb2d.velocity.x < -maxSpeed)
		{
			rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
		}

		if(h < 0 && !facingRight)
			Flip();

		else if(h > 0 && facingRight)
			Flip();
		
	}

	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
