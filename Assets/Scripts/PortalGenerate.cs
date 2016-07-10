using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PortalGenerate : MonoBehaviour {

	public GameObject portalFill;
	public GameObject portalEmpty;
	public GameObject ball;
	public Transform spawnPointStart;
	bool iskillScreen = false;
	public float minDistance = .9f;
	public string colName;
	GameObject pFill;
	GameObject pEmpty;
	public bool port = false;
	public int counter = 0;
	public float startSpeed =1f;
	float speed;
	public float multiplier = 1f;
	public Text score;
	public int gameScore = 0;
	public GameObject gameOver;
	public int colorChange = 0;
	// Use this for initialization
	void Start () {
		speed = startSpeed;
		BeginGame ();
	}

	public void killed()
	{
		Destroy (GameObject.FindGameObjectWithTag("empty"));
		Destroy (GameObject.FindGameObjectWithTag("fill"));

	

		gameOver.SetActive (true);
		iskillScreen = true;
	}

	public void quit()
	{
		Application.Quit();
	}

   	public void BeginGame()
	{	
		
		counter = 0;
		gameScore = 0;
		startSpeed = speed;
		iskillScreen = false;
		colorChange = 0;
	

		Instantiate (ball, spawnPointStart.position, Quaternion.Euler ( 0, 0,Random.Range (0, 360)));

	}
	// Update is called once per frame
	void Update () {


		if (port && GameObject.FindGameObjectWithTag("empty") != null ) {

			if (colName == "Up") {
				GameObject b = Instantiate (ball, GameObject.FindGameObjectWithTag("empty").transform.position + new Vector3(0,-.4f,0), Quaternion.Euler (0, 0, Random.Range (-150,-30f)))as GameObject;
				port = false;
				colName = "";
			}
			if (colName == "Down") {
				GameObject b = Instantiate (ball, GameObject.FindGameObjectWithTag("empty").transform.position + new Vector3(0,.4f,0), Quaternion.Euler (0, 0, Random.Range (30f, 150f)))as GameObject;
				port = false;
				colName = "";

			}
			if (colName == "Left") {
				GameObject b = Instantiate (ball, GameObject.FindGameObjectWithTag("empty").transform.position + new Vector3(.4f,0,0), Quaternion.Euler (0, 0, Random.Range (-50f, 50f)))as GameObject;
				port = false;
				colName = "";

			}
			if (colName == "Right") {
				GameObject b = Instantiate (ball,GameObject.FindGameObjectWithTag("empty").transform.position + new Vector3(-.4f,0,0), Quaternion.Euler (0, 0, Random.Range (117f, 241f)))as GameObject;
				port = false;
				colName = "";

			}

		}

		if ( Input.GetMouseButtonDown (0) && !iskillScreen){


		

		
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if ( Physics.Raycast (ray,out hit,100.0f)) {

				if (hit.collider.gameObject.tag == "fill" && counter % 2 == 0) {
					Destroy (hit.collider.gameObject);

				}

				if (hit.collider.gameObject.tag == "vertical" ) {

					
					Vector3 pos = new Vector3 (hit.collider.transform.position.x , Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);

				

					if (counter % 2 == 0) {
						
							Destroy (GameObject.FindGameObjectWithTag ("fill"));

						 pFill = Instantiate (portalFill, pos, Quaternion.identity) as GameObject;
					} else {
						
							Destroy (GameObject.FindGameObjectWithTag ("empty"));

						 pEmpty = Instantiate (portalEmpty, pos, Quaternion.identity) as GameObject;
					}
					startSpeed = startSpeed + multiplier;
					counter++;
				

				}

				if (hit.collider.gameObject.tag == "horizontal") {


					Vector3 pos = new Vector3 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x,hit.collider.transform.position.y,  0);



					if (counter % 2 == 0) {

						Destroy (GameObject.FindGameObjectWithTag ("fill"));

						GameObject pFill = Instantiate (portalFill, pos, Quaternion.identity) as GameObject;
					} else {

						Destroy (GameObject.FindGameObjectWithTag ("empty"));

						GameObject pEmpty = Instantiate (portalEmpty, pos, Quaternion.identity) as GameObject;
					}
					startSpeed = startSpeed + multiplier;
					counter++;
				
				}
			
			}
//			startSpeed = startSpeed + multiplier;
//			counter++;
			score.text = gameScore.ToString ();


		}

	}
}
