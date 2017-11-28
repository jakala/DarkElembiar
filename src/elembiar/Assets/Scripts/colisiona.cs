using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiona : MonoBehaviour {
	Vector3 escala;

	// Use this for initialization
	void Start () {
		escala = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//cuando empieza la colision
	void OnCollisionEnter2D(Collision2D coll) {
		print ("Enter " + coll.gameObject.name);

	}

	// mientras los dos colliders colisionan
	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.CompareTag("suelo")) {
			print ("ESTA " + coll.gameObject.name);
			escala.x += 0.1f;
			escala.y += 0.1f;
			transform.localScale = escala;
		}
	}

	// al salir de la colision
	void OnCollisionExit2D(Collision2D coll) {
		print ("Salir " + coll.gameObject.name);
		transform.localScale = new Vector3 (1, 1, 1);
	}
}
