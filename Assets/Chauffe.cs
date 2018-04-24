using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chauffe : MonoBehaviour {

	public Material stateNormal;
	public Material stateHot;
	public GameObject hotPoint;
	int chaleur = 0;
	public Rigidbody rb;


	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		print ("La chaleur est à : " + chaleur);
	//	print (" Velocité : " + rb.velocity);

		if (chaleur > 10) {
			GetComponent<Renderer> ().material = stateHot;

		} else {
			GetComponent<Renderer> ().material = stateNormal;
		}


	}

	void OnCollisionStay(Collision collision) {

		if (collision.gameObject.name == "HitboxHot") {
	//	if (collision.gameObject == hotPoint) {
			chaleur ++; 
		
		}

	}
}
