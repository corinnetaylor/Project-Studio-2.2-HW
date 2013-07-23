using UnityEngine;
using System.Collections;

public class PersonAnimations : MonoBehaviour {
	
	public Rigidbody personRigidBody; //assign in inspector
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Velocity magnitude cutoff set to .5 for a more natural looking resting animation
		if (personRigidBody.velocity.magnitude > .5f){

			animation.CrossFade("Walking");

		} else { //otherwise, velocity.magnitude < .5
			animation.CrossFade("Still");
		}
	
	}
}
