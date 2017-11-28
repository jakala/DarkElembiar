using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enviaPublica : MonoBehaviour {
	GameObject cuadrado;
	float pausa=2;
	// Use this for initialization
	void Start () {
		// recojer desde la jerarquia.
		cuadrado = GameObject.Find("Square");
		//;
	}
	
	// Update is called once per frame
	void Update () {
		pausa -= Time.deltaTime;
		if (pausa < 0) {
			cuadrado.GetComponent<Azul> ().poneAzul (2, "Envia", 3f);
		}
	}
}
