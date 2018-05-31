using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	public float HorizontalSpeed = 5;

	public int Level;
	public int Health;
	public int Mana;
	public int Strength;
	public int Agility;
	public int Coin;

	// Use this for initialization
	void Start () {
		
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
