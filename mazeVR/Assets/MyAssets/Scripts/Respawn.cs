using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Respawn : MonoBehaviour {
    public GameObject playerToRespawn;

    private IDictionary<string, GameObject> clients;

    // Use this for initialization
    void Start () {
        clients = new Dictionary<string, GameObject>();
	}

    public void AddClient(string id, Vector3 pos, Quaternion rot)
    {
        print("WARNING, NEW CLIENT!");
        GameObject gameObject = Instantiate(playerToRespawn, new Vector3(0, 1, 0), new Quaternion());
        gameObject.transform.position = pos;
        gameObject.transform.rotation = rot;
        clients.Add(id, gameObject);
    }

    public void MoveClient(string id, Vector3 pos, Quaternion rot)
    {
        GameObject gameObject = clients[id];
        gameObject.transform.position = pos;
        gameObject.transform.rotation = rot;
    }
}
