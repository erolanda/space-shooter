using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorJugador : MonoBehaviour {
	private Rigidbody rb;
	public float velocidad;
	public float xMin, xMax, zMin, zMax, tasaDisparo;
	public GameObject disparo;
	public Transform disparar;
	private float sigDisparo;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");
		Vector3 movimiento = new Vector3 (horizontal, 0.0f, vertical);
		rb.velocity = movimiento * velocidad;
		rb.position = new Vector3 (Mathf.Clamp (rb.position.x, xMin, xMax), 0.0f, Mathf.Clamp (rb.position.z, zMin, zMax));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > sigDisparo) {
			sigDisparo = Time.time + tasaDisparo;
			Instantiate (disparo, disparar.position, disparar.rotation);
		}
	}
}
