using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daga : MonoBehaviour {
	public float velocidad;
	AudioSource sonido;

	public AudioClip[] DagaSonidos;

	Rigidbody2D rb;
	bool golpea = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sonido = GetComponent<AudioSource> ();
		sonido.clip = DagaSonidos [0];
		sonido.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!golpea) {
			float x = Time.deltaTime * velocidad;
			transform.Translate (x, 0, 0);
			//transform.Translate (Vector3.right * Time.deltaTime * velocidad);
			print ("dagaX " + x);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemigo") {
			
			print ("golpea " + coll.gameObject.name);
			transform.parent = coll.gameObject.transform;

			rb.simulated = false;

			// llama a funcion despues de un tiempo
			Invoke ("Para", 0.1f);
			coll.gameObject.SendMessage ("QuitaVida");

			sonido.clip = DagaSonidos [1];
			sonido.Play ();


		}
	}

	void Para() {
		golpea = true;

	}
}
