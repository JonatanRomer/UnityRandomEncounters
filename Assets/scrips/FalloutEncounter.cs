using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FalloutEncounter : MonoBehaviour {

	public int Z;

	// Use this for initialization
	void Start () {

		Z = Random.Range (1, 6);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "NPC") 
		{
			if (Z == 1)
			{
				SceneManager.LoadScene ("Encounter");
			}
			if (Z == 2)
			{
				SceneManager.LoadScene ("Town");
			}
			if (Z == 3)
			{
				SceneManager.LoadScene ("Loot");
			}
			if (Z == 4)
			{
				SceneManager.LoadScene ("Merchant");
			}
			if (Z == 5)
			{
				SceneManager.LoadScene ("Ruins");
			}
		}
	}
}
