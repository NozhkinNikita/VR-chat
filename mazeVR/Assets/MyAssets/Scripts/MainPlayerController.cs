using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerController : MonoBehaviour {
    public float speed = 10f;
    public float rotationSpeed = 100f;
    EventListener listener;


	// Use this for initialization
	void Start () {
        listener = GameObject.FindGameObjectWithTag("Listener").GetComponent<EventListener>();
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        if (Input.anyKey)
        {
            listener.handleEvent(transform.position, transform.rotation);
        }
    }
}
