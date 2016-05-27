using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barrel : MonoBehaviour {
	//randomizers
	public int randomladder;
	private int randomBarrel;
	private int randMaxforladder=6;
	private int randMinforladder=0;
	private int randMaxforbarrel=7;
	private int randMinforbarrel=0;
	private int descendLadder= 2;

//	private int lerpspeed;
//
//	private float lerpfactor;
//	private float startPos;
//	private float endPos;
//
//	private Vector2 lerpMovement;
//	private Vector2 currentPos;
//	private Vector2 destination;
//	public Vector2 currentplatform;
//
	private Collider2D rb;
	private Rigidbody2D rbk;
	private bool isWild;
	private bool islessWild;
	public bool downItgoes;
	private Vector2 currentpos;
	public float rbkfactor;
	public bool isleft = false;
	public float wildonedrop;
	public bool reset = false;
	public float barrelspeed;


	void Start () {
		BarrelType ();
		rb = GetComponent<Collider2D> ();
		rbk	= GetComponent<Rigidbody2D> ();
		if (isWild) {
			tag.Replace ("Barrel","WildBarrel");
			rbk.AddForceAtPosition (Vector2.down * rbkfactor* wildonedrop, currentpos);
		}
		if (islessWild) {
			tag.Replace ("Barrel", "WildBarrel");
		}
		rbk.AddForceAtPosition (Vector2.down * rbkfactor, currentpos);
		if (isWild == false) {
			rbk.AddForceAtPosition (Vector2.right * rbkfactor, currentpos);
		}


	}
	

	void FixedUpdate () {
		currentpos = gameObject.transform.position;
		if (downItgoes == true && isleft && isWild == false) {
			Debug.Log ("going places!");
			rb.isTrigger = true;

		}
		if (downItgoes == true && isleft == false && isWild == false) {
			Debug.Log ("going places!");
			rb.isTrigger = true;

		}
		if (downItgoes == false && isWild == false) {
			rb.isTrigger = false;
		}
		if (isWild) {
			rb.isTrigger = true;
		}
		if (isleft) {
			
			rbk.AddRelativeForce (Vector2.left * rbkfactor);
		} else {
			
			rbk.AddRelativeForce (Vector2.right * rbkfactor);
		}
	}
			void OntriggerEnter2D (Collider2D other){
		if (other.CompareTag ("Player")) {
					//kill player.
		}
	}

	void BarrelType() {
				
				randomBarrel = Random.Range (randMinforbarrel, randMaxforbarrel);
		if (randomBarrel == 1) {
			isWild = true;
		}
				else if (randomBarrel == 2)  {
			islessWild = true;
			//interacts with oil barrel to spawn flamy.
				}
	}

	public void Drop () {
		randomladder = Random.Range (randMinforladder,randMaxforladder);
		if(randomladder <= descendLadder) {
			downItgoes = true;
			Debug.Log ("down it goes!!!");
			rbk.constraints= RigidbodyConstraints2D.FreezePositionX;
			resetvel ();
		}
		else{
			randomladder--;
			//watevs cool man
		}
	

	}
	public void Releasex(){
		rbk.constraints = RigidbodyConstraints2D.None;

		}
	public void resetvel(){
		rbk.velocity = Vector2.zero;
	}
	}


