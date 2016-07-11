using UnityEngine;
using System.Collections;

public class DisableAudio : MonoBehaviour {
	public float timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<AudioSource> ().enabled) {
			Invoke ("Disable", timer);
		}
	}

	void Disable()
	{
		GetComponent<AudioSource> ().enabled = false;
	}
}
