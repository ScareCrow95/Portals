using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	float StartSpeed;
	public float multiplier =1f;
	PortalGenerate PG;
	GameObject Cam;
	// Use this for initialization
	void Start () {

		PG = Camera.main.GetComponent<PortalGenerate>(); 

		StartSpeed = PG.startSpeed;
	//	print (StartSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (StartSpeed * Time.deltaTime,0, 0);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "horizontal" || other.gameObject.tag == "vertical" || other.gameObject.tag == "oV"|| other.gameObject.tag == "oH")
			{
			PG.killed ();
			PG.Emit (gameObject.transform);
			Destroy(gameObject);
		
			}

		if (other.gameObject.tag == "fill") {


			PG.Emit (gameObject.transform);
			PG.port = true;
			PG.gameScore++ ;
			PG.colorChange++;
			if (PG.ObstacleV.transform.localScale.y < 155) {
				PG.ObstacleV.transform.localScale = new Vector3 (PG.ObstacleV.transform.localScale.x, PG.ObstacleV.transform.localScale.y + 5, 1);
			}
			if (PG.ObstacleV.transform.localScale.y >= 155 && PG.ObstacleH.transform.localScale.x < 40) {
				PG.ObstacleH.transform.localScale = new Vector3 (PG.ObstacleH.transform.localScale.x + 2, 1, 1);
			}
			PG.canPlace = true;

			  Destroy (gameObject);
				

		
		}
	
	}


}
