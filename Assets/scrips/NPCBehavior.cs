using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour {

	public float HorizontalSpeed = 0;
	private Rigidbody2D rigidbody2D;
	private RandomEnc RaEn;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
		RaEn = FindObjectOfType<RandomEnc> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate (Vector3.up * HorizontalSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate (Vector3.left * HorizontalSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate (Vector3.down * HorizontalSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate (Vector3.right * HorizontalSpeed * Time.deltaTime);
		}
		
	}
}
