using UnityEngine;
using System.Collections;

public class carScript : MonoBehaviour {

	void Start () {
	
	}

	void OnCollisionEnter (Collision collision) {
		if(collision.gameObject.name == "Hay_b") {
			GameObject.FindWithTag("Carrito").GetComponent<MeshRenderer>().material.color = Color.yellow;
		}
	}
}
