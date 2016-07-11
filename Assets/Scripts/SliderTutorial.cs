using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderTutorial : MonoBehaviour {

	Slider slider;
	// Use this for initialization
	void Start () {
		slider = GetComponent <Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("increase", 4f);
	}

	void increase()
	{
		slider.value += Time.deltaTime*.5f;
	}
}
