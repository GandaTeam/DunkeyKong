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
	private bool isAlive;

	// Use this for initialization
	void Start () 
	{
		isAlive = true;

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
		Debug.Log (score);
	}

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.CompareTag ("ladder")) 
		{
			onLadder = true;
		}

		if (other.CompareTag ("Fire") || other.CompareTag("Barrel")) 
		{
			isAlive = false;
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
