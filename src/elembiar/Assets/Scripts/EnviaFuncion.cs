using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviaFuncion : MonoBehaviour {
	SpriteRenderer render;
	public GameObject circulo;

	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer> ();
		this.SendMessage ("azul");
		circulo.gameObject.SendMessage ("poneAzul");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Azul() {
		render.color = new Color (0f, 0f, 255f);

	}


}
