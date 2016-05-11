using UnityEngine;
using System.Collections;

public class CharControllerScript : MonoBehaviour 
{
	// PUBLIC

	public float maxSpeed = 3f;
	public float jumpforce = 190f;
	public Transform groundCheck;
	public LayerMask whatIsGround;

	// PRIVATE

	private bool facingRight = true;
	private bool grounded = false;
	private float groundRadius = 0.2f;

	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		float move = Input.GetAxisRaw ("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update()
	{
		if (grounded && Input.GetButtonDown ("Jump")) 
		{
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpforce));
		}
			
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
