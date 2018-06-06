using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

using System.IO;
using System.IO.Compression;


public class MainPlayerController : MonoBehaviour {
    public float speed = 10f;
    public float rotationSpeed = 100f;
    EventListener listener;
	private int pageNumber = 1;
	Texture2D deskTexture;
	GameObject imageDesk;

	// Use this for initialization
	void Start () {
        listener = GameObject.FindGameObjectWithTag("Listener").GetComponent<EventListener>();
		deskTexture = Resources.Load ("Images/1") as Texture2D;
		imageDesk = GameObject.Find ("RawImage");
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        if (Input.anyKey)
        {
			if (Input.GetKeyDown (KeyCode.O)) { 
				if (pageNumber > 1)
					pageNumber--;
				print ("Images/" + pageNumber);
				deskTexture = Resources.Load ("Images/"+pageNumber) as Texture2D;
				imageDesk.GetComponent<UnityEngine.UI.RawImage> ().texture = deskTexture;  

			} else
			if (Input.GetKeyDown (KeyCode.P)) { 
				if (pageNumber < 7)
					pageNumber++;
				print ("Images/" + pageNumber);
				deskTexture = Resources.Load ("Images/"+pageNumber) as Texture2D;
				imageDesk.GetComponent<UnityEngine.UI.RawImage> ().texture = deskTexture;  

			} else
            listener.handleEvent(transform.position, transform.rotation);
        }
    }
}
