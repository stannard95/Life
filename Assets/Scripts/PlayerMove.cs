using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class PlayerMove : MonoBehaviour {

	public float walkSpeed = 3.0F;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = new Vector3 (CnInputManager.GetAxis ("Horizontal"), 0, CnInputManager.GetAxis ("Vertical"));
		moveDirection = transform.TransformDirection (moveDirection);
		controller.Move (moveDirection * Time.deltaTime * walkSpeed);

	}
}
