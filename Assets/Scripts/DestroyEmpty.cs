using UnityEngine;
using System.Collections;

public class DestroyEmpty : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "fill") {
			Destroy (gameObject);
		}
	}
}
