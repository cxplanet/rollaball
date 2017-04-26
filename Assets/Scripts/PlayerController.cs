using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame, before
	// it is shown
	void Update () {
		
	}

	// FixedUpdate is called before any physics calulations
	void FixedUpdate() {

		// this maps to x in Unity
		float horizontal = Input.GetAxis ("Horizontal");
		// this maps to z in Unity
		float vertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (horizontal, 0.0f	, vertical);
		
		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
			other.gameObject.SetActive (false);
		//Destroy(other.gameObject);
	}


}
