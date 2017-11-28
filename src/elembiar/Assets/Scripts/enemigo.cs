using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour {
	public SpriteRenderer Estadocolor;
	public enum ESTADOSENEMIGO  {PARADO, ATACANDO, PERSIGUIENDO, MUERTO};
	public ESTADOSENEMIGO estado;
	private Animator animador;

	public int vida_enemigo = 3;
	public float velocidad = 3;
	bool atacando = false;
	bool parado = false;

	AudioSource sonido;
	public AudioClip[] pasos;
	public AudioClip[] fx_arma;
	public AudioClip[] fx_muere;


	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
		animador = GetComponent<Animator> ();
		Andar ();
	}
	
	// Update is called once per frame
	void Update () {
		// esto solo para los colores del informe de estado.
		if (estado == ESTADOSENEMIGO.PARADO) {
			Estadocolor.color = Color.yellow;
		}
		if (estado == ESTADOSENEMIGO.ATACANDO) {
			Estadocolor.color = Color.red;
		}

		if (estado == ESTADOSENEMIGO.PERSIGUIENDO) {
			Estadocolor.color = Color.green;
		}

		if (estado == ESTADOSENEMIGO.MUERTO) {
			Estadocolor.color = Color.black;
		}
	}


	void FixedUpdate() {
		if (estado == ESTADOSENEMIGO.MUERTO) {
			Muere ();
		}

		if(estado == ESTADOSENEMIGO.PERSIGUIENDO) {
			perseguir ();
		}
	
	
	}


	public void perseguir() {
		float x = Time.deltaTime * velocidad;
		transform.Translate (x, 0, 0);
	}

	void QuitaVida() {
		if (vida_enemigo >= 1) {
			vida_enemigo-=10;
		}
		if (vida_enemigo == 0) {
			// muere el enemigo
			estado = ESTADOSENEMIGO.MUERTO;
			Muere ();
		}

	}

	void Parar() {
		parado = true;
		animador.SetBool ("anda", false);
	}

	void Andar() {
		if (estado != ESTADOSENEMIGO.MUERTO) {
			parado = false;
			animador.SetBool ("anda", true);
			estado = ESTADOSENEMIGO.PERSIGUIENDO;
		}
	}

	void Ataca() {
		
		estado = ESTADOSENEMIGO.ATACANDO;
		animador.SetTrigger ("ataca");
	}

	void Muere() {
		animador.SetBool ("anda", false);
		animador.SetTrigger ("muere");
		Destroy (GameObject.Find("detector"));
		Destroy (GetComponent<CapsuleCollider2D> ());
		Destroy (GetComponent<Rigidbody2D> (), 4f);
		Destroy (animador, 4f);
		Destroy (gameObject, 4f);
	}

	public void Paso1()
	{
		sonido.clip = pasos [0];
		sonido.Play ();
	}

	public void Paso2()
	{
		sonido.clip = pasos [1];
		sonido.Play ();
	}

	public void espada_fx()
	{
		sonido.clip = fx_arma[0];
		sonido.Play ();
	}

	public void muerte_fx()
	{
		sonido.clip = fx_muere[0];
		sonido.Play ();
	}


}
