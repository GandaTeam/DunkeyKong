using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barrel : MonoBehaviour {
	//randomizers
	private int randomladder;
	private int randomBarrel;
	private int randMaxforladder=6;
	private int randMinforladder=0;
	private int randMaxforbarrel=9;
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
	public bool isleft;

	//input da ladder,

	public LadderDrop ladropInput;
	void Start () {
		rb = GetComponent<Collider2D> ();
		rbk	= GetComponent<Rigidbody2D> ();
	}
	

	void Update () {
		currentpos = gameObject.transform.position;
		if (downItgoes == true && isleft) {
			Debug.Log ("going places!");
			rb.isTrigger = true;
			rbk.AddForceAtPosition (Vector2.left*rbkfactor,currentpos);
		}
		if (downItgoes == true && isleft == false) {
			Debug.Log ("going places!");
			rb.isTrigger = true;
			rbk.AddForceAtPosition (Vector2.right*rbkfactor,currentpos);
		}
		if (downItgoes == false) {
			rb.isTrigger = false;
		}
//			currentPos = transform.position;
//
//			lerpfactor += Time.deltaTime* lerpspeed;
//			lerpMovement = Vector2.Lerp (currentPos,destination,lerpfactor);
//			transform.position = lerpMovement;
	}

	void Ontrigger2D(Collider2D other) {
		if(other.CompareTag ("ladder")){
			randomladder = Random.Range (randMinforladder,randMaxforladder);
		}
		if(randomladder < descendLadder) {
			rb.enabled = false ;
				Debug.Log ("down it goes!!!");
				}
				else{
			randomladder--;
					//watevs cool man
				}
		if(other.CompareTag ("brokenladder")){
			Debug.Log ("triggered");
			randomladder = Random.Range (randMinforladder,randMaxforladder);
		}
		if(randomladder < descendLadder) {
			rb.enabled = false ;
			Debug.Log ("down it goes!!!");
		}
		else{
			randomladder--;
			//watevs cool man
		}
		}

		void OntriggerExit2D (Collider2D other){
		if(other.CompareTag ("ladder")){
		rb.enabled = true;
		}
		}

	void BarrelType() {
				
				randomBarrel = Random.Range (randMinforbarrel, randMaxforbarrel);
		if (randomBarrel == 1) {
			isWild = true;
			rb.enabled = false;
		}
				else if (randomBarrel == 2)  {
			islessWild = true;
			//interacts with oil barrel to spawn flamy.
				}
	}

	void Drop () {
		rb.enabled = false;
	}
}
