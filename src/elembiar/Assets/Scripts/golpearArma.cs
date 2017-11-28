using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpearArma : MonoBehaviour {
	Animator animador;
	public GameObject fx_golpea;
	public Transform posicion;
	AudioSource sonido;

	// Use this for initialization
	void Start () {
		animador = GetComponent<Animator> ();
		sonido = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.E)) {
			animador.SetTrigger ("golpear");
		}
	}

	public void Crea_fx() {
		GameObject clon_fx_golpea = Instantiate (fx_golpea, posicion.position, Quaternion.identity) as GameObject;
	}


	public void PoneSonido () {
		sonido.Play ();
	}

}
