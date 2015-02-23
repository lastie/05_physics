using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < 50) {
			transform.position += new Vector3 (0f, 0f, 3f) * Time.deltaTime;
		} else if (transform.position.z < 80) {
			transform.position += new Vector3(0f, 0f, 8f) * Time.deltaTime;
		} else if (transform.position.z < 180) {
		transform.position += new Vector3(0f, 0f, 10f) * Time.deltaTime;
		}
	}
}
