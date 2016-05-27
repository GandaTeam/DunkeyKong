using UnityEngine;
using System.Collections;

public class LadderFloor : MonoBehaviour {
	public bool isLEFT;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other){
		Debug.Log ("triggered");
		other.GetComponent<Barrel> ().Releasex ();
		Debug.Log (other.gameObject.name); 
		other.GetComponent<Barrel> ().downItgoes=false;
		if (isLEFT) {
			other.GetComponent<Barrel> ().isleft=true;
		}
		if (isLEFT == false) {
			other.GetComponent<Barrel> ().isleft=false;
		}

	
		}

}