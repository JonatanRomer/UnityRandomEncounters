using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBehavior : MonoBehaviour {

	private RandomEnc RaEn;

	//private GameObject other;

	// Use this for initialization
	void Start () {
		RaEn = FindObjectOfType<RandomEnc> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "NPC") 
		{
			//Destroy (other.gameObject);
			RaEn.X = RaEn.X - 7;
			Debug.Log ("Yoink");
		}
	}
}
