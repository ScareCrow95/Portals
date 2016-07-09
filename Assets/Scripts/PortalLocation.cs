using UnityEngine;
using System.Collections;

public class PortalLocation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		
	
		//	Camera.main.GetComponent<PortalGenerate> ().port = true;
		Camera.main.GetComponent<PortalGenerate> ().colName = other.gameObject.name;
	}
	
	
}
