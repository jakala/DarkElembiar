﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaController : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.SendMessage ("QuitaVida");
			print ("matando a jugador");
		}
	}

	void OnTriggerStay2D(Collider2D coll) {

	}

}
