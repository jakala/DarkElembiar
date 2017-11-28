using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaOla : MonoBehaviour {

	public GameObject[] enemigos_tipo;
	// Use this for initialization
	void Start () {
		StartCoroutine (CreaEnemigo (2, enemigos_tipo));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator CreaEnemigo(float tiempo, GameObject[]  enemigo) {
		for (int i = 0; i < enemigo.Length; i++) {
			yield return new WaitForSeconds (tiempo);
			Instantiate (enemigo [i]);
		}
	}

}
