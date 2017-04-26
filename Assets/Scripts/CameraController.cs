using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Take the position difference between the camera and the player object (a ball)
	void Start () {
		offset = transform.position - player.transform.position;	
	}
	
	// Update to follow the camera - do it at the last calculation, as
	// LateUpdate is run after all of the Updates are processed
	void LateUpdate () {
		transform.position = player.transform.position + offset;		
	}
}
