using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextDisplayer : MonoBehaviour {

	public string textShownOnScreen;
	public string fullText = "The text you want shown on screen with typewriter effect.";
	public float wordsPerSecond = 2; // speed of typewriter
	private float timeElapsed = 0;
	 //private int timeElapsedInt = System.Convert.ToInt32(timeElapsed);

	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
		textShownOnScreen = GetWords(fullText, timeElapsed * wordsPerSecond);
	}
	private string GetWords(string text, float wordCount)
	{
		float words = wordCount;
		// loop through each character in text
		for (int i = 0; i < text.Length; i++)
		{ 
			if (text[i] == ' ')
			{
				words--;
			}
			if (words <= 0)
			{
				return text.Substring(0, i);
			}
		}
		return text;
	}
}