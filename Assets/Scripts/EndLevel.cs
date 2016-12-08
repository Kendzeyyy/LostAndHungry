using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
This script ends levels and moves to the next one. There is another script for Jet level. Check EndLevelJet.cs.
Authors:
Mikael Ahlström
Kendy Nguyen
*/
public class EndLevel : MonoBehaviour {

	private float timeLeft = 360;
	
	// Update is called once per frame
	void Update () {
	
		timeLeft -= Time.deltaTime;
    	if ( timeLeft < 0 )
    	{
         SceneManager.LoadScene("StartMenu");
    	}
	}
}
