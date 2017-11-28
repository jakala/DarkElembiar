using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectaJugador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			gameObject.SendMessageUpwards ("Ataca");
			print ("detectado!!!");
		}
		//gameObject.SendMessageUpwards ("Ataca");
	}

	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.SendMessage ("QuitaVida");
			//Invoke ("Espera", 2f);
		
		}
		print ("detectado en stay!!!");
	}

	void OnTriggerExit2D(Collider2D coll) {
		gameObject.SendMessageUpwards ("Andar");
		print ("saliendo de exit");

	}

	void Espera() {
		// esta funcion no hace nada, solo para esperar
	}
}
