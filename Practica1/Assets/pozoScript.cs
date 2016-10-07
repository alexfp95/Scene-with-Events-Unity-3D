using UnityEngine;
using System.Collections;

public delegate void metodoDelegado ();

public class pozoScript : MonoBehaviour {
	
	public event metodoDelegado Evento;

	void Start () {
	
	}
	
	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.name == "Player") {
			Evento ();
		}
	}
}
