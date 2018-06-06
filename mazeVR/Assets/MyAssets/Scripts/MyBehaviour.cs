using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyBehaviour : MonoBehaviour {
	public void Start() {
		StartCoroutine(GetText());
	}

	IEnumerator GetText() {
		UnityWebRequest www = UnityWebRequest.Get("http://www.my-server.com");
		yield return www.SendWebRequest();  

		if(www.isNetworkError || www.isHttpError) {
			print(www.error.ToString());
		}
		else {
			// Show results as text
	
			print (www.downloadHandler.text.ToString());

			// Or retrieve results as binary data
			byte[] results = www.downloadHandler.data;
		}
	}
}