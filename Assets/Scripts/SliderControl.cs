using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour {

	public Slider slider;
	public float timer = 3f;
	bool a = true;
	public float t = 0 ;
	// Use this for initialization
	void Start () {
		t = 0 ;
		if (GameObject.FindGameObjectWithTag ("empty") != null) {
			GameObject.FindGameObjectWithTag ("empty").GetComponent<SliderControlOther> ().portalMade = false;
		}
		slider = GameObject.FindGameObjectWithTag ("slider").GetComponent<Slider>();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (a) {
			t += Time.deltaTime;
			slider.value = t;
			if (t >= timer) {
				Camera.main.GetComponent<PortalGenerate> ().killed ();
				a = false;
			}

		}
		if (GameObject.FindGameObjectWithTag ("empty") != null) {
			if (!GameObject.FindGameObjectWithTag ("empty").GetComponent<SliderControlOther> ().portalMade) {
				t += Time.deltaTime * .5f;
				slider.value = t;
				if (t >= timer) {
					Camera.main.GetComponent<PortalGenerate> ().killed ();
					t = 0;
					GameObject.FindGameObjectWithTag ("empty").GetComponent<SliderControlOther> ().portalMade = true;
				}
			} else {
				t = 0;
				slider.value = t;
			}
		}
	}
	public void changeT()
	{
		t = 0;
	}
}
