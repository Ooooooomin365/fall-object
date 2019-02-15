using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airresistance : MonoBehaviour {
	
	public float keisu;
	
	float fallTime = 0;
	
	Rigidbody force;
	
	void Start() {
		this.force = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		force.AddForce(- keisu * force.velocity);
	}
	
	void Update() {
		fallTime += Time.deltaTime;
	}
	
	void OnCollisionEnter(Collision other){
		Debug.Log(fallTime);
	}
}
