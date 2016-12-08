using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
This script ends jetlevel and moves to the final cutscene.
Authors:
Mikael Ahlström
Kendy Nguyen
*/
public class EndLevelJet : MonoBehaviour {

	private float timeLeft = 95;
	
	// Update is called once per frame
	void Update () {
	
		timeLeft -= Time.deltaTime;
    	if ( timeLeft < 0 )
    	{
         SceneManager.LoadScene("dialog_level4");
    	}
	}
}
