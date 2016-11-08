using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	Rigidbody rb;  

	float randomNum; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}

	void FixedUpdate () {
		rb.velocity = transform.forward * 50f + Physics.gravity;

		Ray moveRay = new Ray (transform.position, transform.forward);

		Debug.DrawRay(moveRay.origin,moveRay.direction, Color.red);

		randomNum = Random.value;

		if (Physics.SphereCast (moveRay, 1f, 2f) == true) {

			if (randomNum < .33f) {
				transform.Rotate (0f, 180f, 0f);
			}
			if (randomNum > .33f && randomNum < .66f) {
				transform.Rotate (0f, 90f, 0f);
			}
			if (randomNum > .66f) {
				transform.Rotate (0f, -90f, 0f);
			}
		}
	}
}
