using UnityEngine;
using System.Collections;

public class LadderFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other){
		Debug.Log ("triggered");
		Debug.Log (other.gameObject.name); 
		other.GetComponent<Barrel> ().downItgoes=false;
}

}