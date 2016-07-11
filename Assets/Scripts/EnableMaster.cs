using UnityEngine;
using System.Collections;

public class EnableMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void enable () {
		Camera.main.GetComponent<PortalGenerate> ().enabled = true;
	}
}
