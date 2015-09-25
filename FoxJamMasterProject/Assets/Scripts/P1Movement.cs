using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
	
}

public class P1Movement : MonoBehaviour {
    Rigidbody2D PRigidbody;
    Animator anime;
	public float speed = 1.0f;
	public Boundary bounds;
    Vector3 movement;
	// Use this for initialization
	void Start () 
	{
        PRigidbody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
	}
	
   //use fixed update for physics based character
	void FixedUpdate()
	{
        //store input axis
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

        Move(moveHorizontal, moveVertical);

        //Turning();
        //Animating(h, v);
        
		//(Mathf.Clamp (Rigidbody2D.position.x, bounds.xMin, bounds.xMax),
		// Mathf.Clamp (Rigidbody2D.position.y, bounds.yMin, bounds.yMax));
	}

    void Move (float h, float v)
    {
        movement.Set (h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        PRigidbody.MovePosition(transform.position + movement);
    }

    //  void Turning() {}

  //  void Animating(float h, float v)
  //  {
     //   bool walking = h != 0f;

   // }
}
