using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	//Cat catScript;
	public Transform cat;

	void Start () {
		//catScript = GameObject.Find ("Cat").GetComponent<Cat> ();
	}

	void FixedUpdate () {
		Vector3 directionToCat = new Vector3 ();
		directionToCat = cat.position - this.transform.position;

		if (Vector3.Angle (this.transform.forward, directionToCat) <= 130f) {
			Ray mouseRay = new Ray (this.transform.position, directionToCat);
			RaycastHit mouseRayHitInfo;

			if (Physics.Raycast (mouseRay, out mouseRayHitInfo, 100f) == true) {
				if (mouseRayHitInfo.collider.tag == "Cat" && mouseRayHitInfo.distance < 15f) {
					this.GetComponent<Rigidbody> ().AddForce (-directionToCat.normalized * 10000f);
				}
			}
		}
	}
}
