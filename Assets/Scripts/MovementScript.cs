using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	Rigidbody rb; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = transform.forward * 10f;
	}
}
