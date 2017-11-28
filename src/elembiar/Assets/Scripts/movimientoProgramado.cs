using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoProgramado : MonoBehaviour {
	public float velocidad;
	private float x;
	private float y;

	public bool usaCos = false;
	public bool usaSin = false;
	public bool usaTan = false;
	public float frecuencia;

	float pos_x;
	float pos_y;

	// Use this for initialization
	void Start () {
		pos_x = transform.position.x;
		pos_y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		x = pos_x;
		y = pos_y;

		x += Time.deltaTime;

		Vector3 direccion = Vector3.left;

/*
		transform.position = new Vector3 (velocidad * Time.deltaTime, 0, 0);
		print (Time.deltaTime);
*/
	
/*
		// AVANCE del objeto.
		x += Time.deltaTime;
		transform.Translate (x * velocidad, 0, 0);
*/


		// movimiento de oscilacion. podemos llegar a hacer una orbita, o unas cuchillas que caen y suben, o una plataforma que se mueve de izquierda a derecha.
		if (usaSin)
			y = velocidad * Mathf.Sin (Time.timeSinceLevelLoad * frecuencia) + pos_y;
	
		if(usaCos)
			x = velocidad * Mathf.Cos (Time.timeSinceLevelLoad* frecuencia) + pos_x;

		if(usaTan)
			x = velocidad * Mathf.Tan (Time.timeSinceLevelLoad * frecuencia) + pos_x;

		transform.position = new Vector3 (x, y, 0);


	}
}
