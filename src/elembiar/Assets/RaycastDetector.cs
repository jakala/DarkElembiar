using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDetector : MonoBehaviour {
	public float x_off;
	public float y_off;
	public float distancia;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {
		Vector2 nueva_pos = new Vector2 (transform.position.x + x_off, transform.position.y + y_off);
		Ray2D rayo = new Ray2D (nueva_pos, Vector2.right);
		//es especifico para el motor de fisicas
		RaycastHit2D hit =  Physics2D.Raycast(rayo.origin, rayo.direction, distancia);
		//para que no de error
		if(hit.collider!= null) {
			print (hit.collider.name);			
		}
		Debug.DrawRay (rayo.origin, rayo.direction*distancia, Color.blue);

		// solo detecta un layer determinado.

		int mascara = 1 << LayerMask.NameToLayer ("Enemigo") ;  
		mascara = ~mascara;
		// convierto el ayermasc en cadena binaria
		print(System.Convert.ToString(mascara, 2));


		// Detectar mas de un collider
		ContactFilter2D filtro = new ContactFilter2D ();
		filtro.SetLayerMask (mascara);
		RaycastHit2D[] hits = new RaycastHit2D[5];
		int num = Physics2D.Raycast(rayo.origin, rayo.direction, filtro, hits, distancia);

		print ("el primero: " + hits [0].collider.name + "distancia primero: "+hits[0].distance + " segundo: " + hits [1].collider.name);
//		RaycastHit2D hit2 =  Physics2D.Raycast(rayo.origin, rayo.direction, distancia);
		Debug.DrawRay (rayo.origin, rayo.direction*distancia, Color.red);

	}
}
