using UnityEngine;
using System.Collections;

public class CharColliderScript : MonoBehaviour 
{

	// PUBLIC

	public float climbSpeed;
	public int score;

	// PRIVATE

	private Rigidbody2D playerRigidbody;
	private CircleCollider2D charCollider;
	private float climbVelocity;
	private float gravityStore;
	private bool onLadder;

	// Use this for initialization
	void Start () 
	{
		playerRigidbody = GetComponent<Rigidbody2D> ();
		charCollider = GetComponent<CircleCollider2D> ();
		gravityStore = playerRigidbody.gravityScale;
	}

	void Update()
	{
		if (onLadder) 
		{
			playerRigidbody.gravityScale = 0f;

			climbVelocity = climbSpeed * Input.GetAxisRaw ("Vertical");

			playerRigidbody.velocity = new Vector2 (playerRigidbody.velocity.x, climbVelocity);

			charCollider.enabled = false;
		}

		if (!onLadder) 
		{
			playerRigidbody.gravityScale = gravityStore;

			charCollider.enabled = true;
		}
	}

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.CompareTag ("ladder")) 
		{
			onLadder = true;
		}
	}

	void OnTriggerExit2D (Collider2D other) 
	{
		if (other.CompareTag ("ladder")) 
		{
			onLadder = false;
		}
	}
}
