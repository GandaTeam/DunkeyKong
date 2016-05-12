using UnityEngine;
using System.Collections;

public class LadderDrop : MonoBehaviour {
	private int randomladder;
	private int randomBarrel;
	private int randMaxforladder=6;
	private int randMinforladder=0;
	private int randMaxforbarrel=9;
	private int randMinforbarrel=0;
	private int descendLadder= 2;

	public GameObject barrel;
	public bool descend;
	public bool isLeft;

	// Use this for initialization
	void Start () {
		descend = false;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D (Collider2D other){
		Debug.Log ("triggered");
		Debug.Log (other.gameObject.name); 
		descend = true;
		other.GetComponent<Barrel> ().downItgoes=true;
		if (isLeft) {
			other.GetComponent<Barrel> ().isleft=true;
		}
	}
	void Ontrigger2D(Collider2D other) {
		if(other.CompareTag ("ladder")){
			randomladder = Random.Range (randMinforladder,randMaxforladder);
		}
		if(randomladder < descendLadder) {
			
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
			
			Debug.Log ("down it goes!!!");
		}
		else{
			randomladder--;
			//watevs cool man
		}
	}

	void OntriggerExit2D (Collider2D other){
		if(other.CompareTag ("ladder")){
			
		}
	}

}
