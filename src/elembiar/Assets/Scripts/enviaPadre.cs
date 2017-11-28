using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enviaPadre : MonoBehaviour {
	SpriteRenderer render;
	float pausa=2;
	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		pausa -= Time.deltaTime;
		if (pausa < 0)
			gameObject.SendMessageUpwards ("poneAzul");
	}

	public void poneAzul() {
		render.color = new Color (0f, 0f, 255f);

	}
}
