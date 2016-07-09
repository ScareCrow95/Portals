using UnityEngine;
using System.Collections;

public class ColorLerp : MonoBehaviour {

	// Use this for initialization
	float timeLeft;
	Color targetColor;
	void Update()
	{
		if (timeLeft <= Time.deltaTime)
		{
			// transition complete
			// assign the target color
			GetComponent<SpriteRenderer>().color= targetColor;
			// start a new transition
			targetColor = new Color(Random.value, Random.value, Random.value);
			timeLeft = 8.0f;
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
}
