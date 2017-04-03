using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar : MonoBehaviour {
	private Rigidbody rb;
	public float giro;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * giro;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
