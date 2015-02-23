using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Wind : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z > 60 && transform.position.z < 130) {
			GetComponent<ConstantForce>().force = new Vector3(0f, 0f, 10f);
		}
		if (transform.position.z > 135) {
			GetComponent<Rigidbody>().drag = 10000;
		}
	}
}
