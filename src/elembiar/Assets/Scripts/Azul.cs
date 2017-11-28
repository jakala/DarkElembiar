using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul : MonoBehaviour {
	SpriteRenderer render;
	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void poneAzul(int i, string juan, float d) {
		render.color = new Color (0f, 0f, 255f);
		print (juan + " " + i + " ");

	}

	public void poneRojo() {
		render.color = new Color (255f, 0f, 0f);
	}

	public void poneBlanco() {
		render.color = new Color (255f, 255f, 255f);
	}

}
