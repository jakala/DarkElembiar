using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class guerrero : MonoBehaviour {
	int mirar;
	private float max_vida = 200;
	public float vida;
	static int num_dagas = 3;
	public Image vida_img;
	bool muerto = false;
	public GameObject Panel_GameOver; 

	public float velocidad = 1.0F;
	Animator animador;
	public GameObject daga;
	public Transform posicion_daga;

	AudioSource sonido;
	public AudioClip[] pasos;
	public AudioClip[] fx_arma;
	public AudioClip[] fx_muere;


	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
		animador = GetComponent<Animator> ();
		Panel_GameOver.SetActive (false);
		vida = max_vida;
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * velocidad;
		float y = Input.GetAxis ("Vertical") * Time.deltaTime * velocidad;
		print (x);
		//animador.SetInteger ("velocidad", (int)(Mathf.Abs (Input.GetAxis ("Horizontal") * 100))); //manda al animator el parametro.
		if (!muerto) {
			transform.Translate (x, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.Q)) {
			if (num_dagas > 0) {
				animador.SetTrigger ("lanzar");
				num_dagas--;
			}
		}

		mirar = (x > 0) ? 1: -1;
	//	if (transform.localScale.x != mirar)
//		  transform.localScale = new Vector3(mirar, 1, 1);

	}

	void crea_fx_daga() {
		GameObject clon_fx_daga = Instantiate (daga, posicion_daga.position, Quaternion.identity) as GameObject;
	}

	void QuitaVida() {
		if (vida >= 0)
			vida -= 1;
		
		if (vida <= 0 && !muerto) {
			animador.SetTrigger ("morir");
			muerto = true;
		}
		vida_img.fillAmount = vida / max_vida;
	}

	public void Reinicia() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		Time.timeScale = 1;
	}

	public void GameOver() {
		Panel_GameOver.SetActive (true);
		Time.timeScale = 0;
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

