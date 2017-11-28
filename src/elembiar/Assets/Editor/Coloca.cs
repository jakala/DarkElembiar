using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Coloca : MonoBehaviour {
	
	static string[] nombre_huesos={"cintura","tronco","cabeza","brazo_i","ante_i","mano_i","brazo_d","ante_d","mano_d","pierna_i","panto_i","pie_i","pierna_d","panto_d","pie_d"};
	static List<GameObject> Objetos=new List<GameObject>(0);
	[MenuItem ("Window/Crea")]
	public static void  CreaHuesos () {
		foreach(string nombre in nombre_huesos){
			GameObject hueso = new GameObject ();
			hueso.gameObject.name = nombre;
			//hueso.AddComponent<Anima2D.Bone2D> ();
			Objetos.Add (hueso);
		}
		Objetos [1].gameObject.transform.parent = Objetos [0].gameObject.transform;
		Objetos [2].gameObject.transform.parent = Objetos [1].gameObject.transform;
		Objetos [3].gameObject.transform.parent = Objetos [1].gameObject.transform;
		Objetos [4].gameObject.transform.parent = Objetos [3].gameObject.transform;
		Objetos [5].gameObject.transform.parent = Objetos [4].gameObject.transform;
		Objetos [6].gameObject.transform.parent = Objetos [1].gameObject.transform;
		Objetos [7].gameObject.transform.parent = Objetos [6].gameObject.transform;
		Objetos [8].gameObject.transform.parent = Objetos [7].gameObject.transform;
		Objetos [9].gameObject.transform.parent = Objetos [0].gameObject.transform;
		Objetos [10].gameObject.transform.parent = Objetos [9].gameObject.transform;
		Objetos [11].gameObject.transform.parent = Objetos [10].gameObject.transform;
		Objetos [12].gameObject.transform.parent = Objetos [0].gameObject.transform;
		Objetos [13].gameObject.transform.parent = Objetos [12].gameObject.transform;
		Objetos [14].gameObject.transform.parent = Objetos [13].gameObject.transform;
	}
}
