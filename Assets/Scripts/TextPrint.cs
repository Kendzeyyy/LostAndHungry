using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
 This script creates a typewriter effect for UI text.
 attach to UI Text component (with the full text already there)
 author: Ahlstrom
*/


public class TextPrint : MonoBehaviour 
{

	Text txt;
	string story;

	void Awake () 
	{	
		// Gets text from the UI text object
		txt = GetComponent<Text> ();
		story = txt.text;
		txt.text = "";

		// TODO: add optional delay when to start
		StartCoroutine ("PlayText");
	}

	IEnumerator PlayText()
	{
		// loop that prints 1 char at the time
		foreach (char c in story) 
		{
			txt.text += c;
			yield return new WaitForSeconds (0.025f);
		}
	}

}