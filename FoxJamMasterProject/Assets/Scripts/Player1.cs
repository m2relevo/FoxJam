﻿using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {
	
	public float maxSpeed = 3;
	public float speed = 50f;
	public float jumpPower = 200f;
	
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
		anim.SetFloat ("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
		
		if (Input.GetAxis ("Horizontal") < 0f)
		{
			transform.localScale = new Vector3(1,1,1);
		}
		if (Input.GetAxis ("Horizontal") > -0f) 
		{
			transform.localScale = new Vector3(-1,1,1);
		}
		
		if (Input.GetButtonDown ("Jump") && grounded)
		{
			rb2d.AddForce(Vector2.up * jumpPower);
		}
	}
	
	void FixedUpdate()
	{
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
		
	}
}
