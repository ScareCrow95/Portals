using UnityEngine;
using System.Collections;

public class ColorLerp : MonoBehaviour {

	// Use this for initialization
	float timeLeft;
	Color targetColor;
	void Update()
	{
		if (Camera.main.GetComponent<PortalGenerate> ().colorChange == 5) {
			color ();
			Invoke ("resetColor", 2f);
		//	print (Camera.main.GetComponent<PortalGenerate> ().colorChange);

		}
	}

	void color()
	{
		if (timeLeft <= Time.deltaTime)
		{
			// transition complete
			// assign the target color
			GetComponent<SpriteRenderer>().color= targetColor;
			// start a new transition
			targetColor = new Color(Random.value, Random.value, Random.value,1);
			timeLeft = 2.0f;
		}
		else
		{
			// transition in progress
			// calculate interpolated color
			GetComponent<SpriteRenderer>().color = Color.Lerp(GetComponent<SpriteRenderer>().color, targetColor, Time.deltaTime / timeLeft);
			// update the timer
			timeLeft -= Time.deltaTime;
		}
	}
	void resetColor()
	{
		Camera.main.GetComponent<PortalGenerate> ().colorChange = 0;

	}
}
