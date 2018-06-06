using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	// EventListener listener;

	Camera m_MainCamera;

	// Use this for initialization
	void Start () {
		m_MainCamera = Camera.main;
		// listener = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<EventListener>();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 moveDirection = Vector3.zero;
		if (Input.GetKey (KeyCode.W)) {  
			Debug.Log ("azaz1"); 
			moveDirection += m_MainCamera.transform.forward;
		}
		if (Input.GetKey (KeyCode.S))
			moveDirection -= m_MainCamera.transform.forward;
		if (Input.GetKey (KeyCode.D))
			moveDirection += m_MainCamera.transform.right;
		if (Input.GetKey (KeyCode.A))
			moveDirection -= m_MainCamera.transform.right;
		transform.position += moveDirection.normalized * speed * Time.deltaTime;

	//	transform.rotation = m_MainCamera.transform.rotation;
	// 	if (Input.anyKey) {
	// 		listener.handleEvent(transform.position, transform.rotation);
	// 	}
	}
}
