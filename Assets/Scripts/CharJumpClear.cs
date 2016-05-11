using UnityEngine;
using System.Collections;

public class CharJumpClear : MonoBehaviour 
{

	// PUBLIC

	public int singleHazard = 100;
	public int doubleHazard = 300;
	public int tripleHazard = 800;

	public GameObject player;

	// PRIVATE

	private int hazardCound = 0;
	private CharColliderScript charCollider;
	private CharControllerScript charController;

	// Use this for initialization
	void Start () 
	{
		charCollider = player.GetComponent<CharColliderScript> ();
		charController = player.GetComponent<CharControllerScript> ();
	}

	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.CompareTag ("Barrel") || other.CompareTag ("Fire")) 
		{
			hazardCound++;
		}
	}

	void Update()
	{
		if (charController.grounded && hazardCound == 1) 
		{
			charCollider.score += singleHazard;
			hazardCound = 0;
		}
		else if (charController.grounded && hazardCound  == 2)
		{
			charCollider.score += doubleHazard;
			hazardCound = 0;
		}
		else if (charController.grounded && hazardCound  == 3)
		{
			charCollider.score += tripleHazard;
			hazardCound = 0;
		}
	}
}
