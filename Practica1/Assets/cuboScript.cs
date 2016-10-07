using UnityEngine;
using System.Collections;

public class cuboScript : MonoBehaviour {

	void Start () {
		GetComponent<MeshRenderer> ().enabled = false;
		GameObject.FindWithTag ("Pozo").GetComponent<pozoScript> ().Evento += MetodoEjecutar;
	}
	
	void MetodoEjecutar () {
		GetComponent<MeshRenderer> ().enabled = true;
	}
}
