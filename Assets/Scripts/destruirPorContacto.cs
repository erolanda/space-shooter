using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirPorContacto : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider otro){

		Destroy (otro.gameObject);
	}
}
