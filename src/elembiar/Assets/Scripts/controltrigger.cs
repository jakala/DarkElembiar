using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controltrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D Coll) {
		print ("Entramos en collider");
		Coll.gameObject.SendMessage("poneRojo");
	}

	void OnTriggerStay2D(Collider2D Coll) {
		print ("Stay en collider");
	}

	void OnTriggerExit2D(Collider2D Coll) {
		print ("Sale en collider");
		Coll.gameObject.SendMessage("poneBlanco");
	}
}
