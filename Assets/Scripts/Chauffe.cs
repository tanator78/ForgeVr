using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chauffe : MonoBehaviour {

	public Material stateNormal;
	public Material stateHot;
	double chaleur = 0;
	public Rigidbody rb;

	[SerializeField]
	private GameObject four;

	public AudioClip feuLit;
	public AudioClip feuNormal;
	//[SerializeField]
	//private AudioSource fireActive;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		print ("La chaleur est à : " + chaleur);
		//	print (" Velocité : " + rb.velocity);

						// la chaleur doit baisser progressivement
		//StartCoroutine(Example());

		if ( chaleur > 10)
		{
			chaleur = chaleur - 0.1;
		}



		if (chaleur > 100) {
			GetComponent<Renderer> ().material = stateHot;

		} else {
			GetComponent<Renderer> ().material = stateNormal;
		}


	}
	


	void OnTriggerStay(Collider collider) {

		AudioSource audio = four.GetComponent<AudioSource>();

		audio.clip = feuLit;

		if (collider.gameObject.name == "HitboxHot") {	// pour le moment, le nom doit correspondre exactement ! 
	//	if (collider.gameObject == hotPoint) {
			chaleur = chaleur + 0.5; 
		
		}

	}
}
