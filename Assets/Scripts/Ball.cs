using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	float StartSpeed;
	public float multiplier =1f;
	GameObject Cam;
	// Use this for initialization
	void Start () {
		StartSpeed = Camera.main.GetComponent<PortalGenerate> ().startSpeed;
	//	print (StartSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (StartSpeed * Time.deltaTime,0, 0);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "horizontal" || other.gameObject.tag == "vertical" )
			{
			Camera.main.GetComponent<PortalGenerate> ().killed ();

				Destroy(gameObject);
			}
		if (other.gameObject.tag == "fill") {
			Camera.main.GetComponent<PortalGenerate> ().port = true;
			Camera.main.GetComponent<PortalGenerate> ().gameScore++ ;
			Camera.main.GetComponent<PortalGenerate> ().colorChange++;


			  Destroy (gameObject);

		}
	}
}
