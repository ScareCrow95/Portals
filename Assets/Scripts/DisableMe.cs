using UnityEngine;
using System.Collections;

public class DisableMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("disable", .5f);
	}
	
	// Update is called once per frame
	void disable () {
		gameObject.SetActive (false);
	}
}
