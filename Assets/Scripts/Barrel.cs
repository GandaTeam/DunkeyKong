using UnityEngine;
using System.Collections;

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
	private bool isWild;
	private bool islessWild;

	void Start () {
		rb = GetComponent<Collider2D> ();
	}
	

	void Update () {
//			currentPos = transform.position;
//
//			lerpfactor += Time.deltaTime* lerpspeed;
//			lerpMovement = Vector2.Lerp (currentPos,destination,lerpfactor);
//			transform.position = lerpMovement;
	}

	void OnCollider(Collider2D other) {
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
		}

		void OnColliderExit (Collider2D other){
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


}
