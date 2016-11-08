using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {

	public Transform mouse;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		if (mouse == null) {
			return;
		}
		Vector3 directionToMouse = new Vector3 ();
		directionToMouse = mouse.position - this.transform.position;

		if (Vector3.Angle (this.transform.forward, directionToMouse) < 30f) {
			Ray catRay = new Ray (this.transform.position, directionToMouse);
			RaycastHit catRayHitInfo;

			if (Physics.Raycast (catRay, out catRayHitInfo, 100f) == true) {
				if (catRayHitInfo.collider.tag == "Mouse" && catRayHitInfo.distance < 20f) {
						Destroy (mouse.gameObject);
					} 
						this.GetComponent<Rigidbody> ().AddForce (directionToMouse.normalized * 1000f);
					}
				}
			}
}
