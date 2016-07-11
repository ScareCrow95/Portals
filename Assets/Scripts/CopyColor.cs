using UnityEngine;
using System.Collections;

public class CopyColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = GameObject.FindGameObjectWithTag ("bg").GetComponent<SpriteRenderer> ().color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
