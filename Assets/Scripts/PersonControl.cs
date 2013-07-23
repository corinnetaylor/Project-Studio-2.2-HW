using UnityEngine;
using System.Collections;

public class PersonControl : MonoBehaviour {
	
	Vector3 moveVector;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Forward and backward movement
		moveVector = transform.forward * Input.GetAxis("Vertical");
			
		//Turning is determined by keyboard rather than mouse input
		transform.Rotate (0f,Input.GetAxis("Horizontal"),0f);

	}
	
	void FixedUpdate(){
		
		rigidbody.AddForce(moveVector, ForceMode.VelocityChange);
		
	}
}
