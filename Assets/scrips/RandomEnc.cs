using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomEnc : MonoBehaviour {

	public bool OldSchool;
	public bool NewSchool;

	public int X;

	// Use this for initialization
	void Start () {

		if (OldSchool) 
		{
			X = Random.Range (0, 100);
		}

		if (NewSchool) 
		{
			X = Random.Range (64, 256);
		}

	}

	// Update is called once per frame
	void Update () {

		if (OldSchool) 
		{
			if (X < 8) 
			{
				SceneManager.LoadScene ("Encounter");
			}
		}

		if (NewSchool) 
		{
			if (X <= 0) 
			{
				SceneManager.LoadScene ("Encounter");
			}
		}

	}
}
