using UnityEngine;
using System.Collections;

public class CharJumpClear : MonoBehaviour 
{
	// PRIVATE

	private CharColliderScript charCollider;

	// Use this for initialization
	void Start () 
	{
		charCollider = GetComponent<CharColliderScript> ();
	}

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.CompareTag ("Barrel") || other.CompareTag ("Fire")) 
		{
			charCollider.score += 100;
		}
		if (other.CompareTag ("Barrel")) 
		{
			charCollider.score += 100;
		}
	}
}
