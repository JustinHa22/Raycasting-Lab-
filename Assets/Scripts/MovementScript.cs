using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	Rigidbody rb; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//Ray moveray = new Ray (transform.position, transform.forward);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = transform.forward * 10f;

		Ray frontRay = new Ray (transform.position, transform.forward);
		Ray rightRay = new Ray (transform.position, transform.right); 
		Ray leftRay = new Ray (transform.position, -transform.right);

		RaycastHit rayHit = new RaycastHit ();

		Debug.DrawRay (frontRay.origin, frontRay.direction * 10f, Color.red);
		Debug.DrawRay (rightRay.origin, rightRay.direction * 20f, Color.blue);
		Debug.DrawRay (leftRay.origin, leftRay.direction * 20f, Color.yellow);

	}
}
