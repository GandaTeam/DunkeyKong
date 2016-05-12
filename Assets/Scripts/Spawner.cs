using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject Barrel;
	public Vector3 spawnSpot;
	public float spawntimer;
	private float chronotimer;

	void Start() {
		spawnSpot = transform.position;
		GameObject BarrelSpawn = Instantiate (Barrel);
		}
	
	// Update is called once per frame
	void Update () {
		chronotimer += Time.deltaTime;
		if (spawntimer < chronotimer) {
			BarrelSpawn ();
			chronotimer -= spawntimer;
		}
		Debug.Log (chronotimer);
		//BarrelSpawn ();
	}
	private void BarrelSpawn() {
		GameObject BarrelSpawn = Instantiate (Barrel);
	}
}
