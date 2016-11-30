using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* Author: Kendy Nguyen
 * This script is for the main menu which
 * you will see as  soon when you open
 * the game. In maine menu you have to
 * choose
 */


public class StartMenu : MonoBehaviour {


//------PlayButton--------------------------------------------------------------------------------------------------

	public void Play (){
		SceneManager.LoadScene ("Level1");		

	}

//--------TextButton------------------------------------------------------------------------------------------------

	//Story page 1
	public void Story (){
		SceneManager.LoadScene ("StoryText");
	}

	//Story page 2
	public void StoryTwo (){
		SceneManager.LoadScene ("StoryText2");
	}

	//Story page 3
	public void StoryThree (){
		SceneManager.LoadScene ("StoryText3");
	}

	//Story page 4
	public void StoryFour (){
		SceneManager.LoadScene ("StoryText4");
	}

	//Return to Main Menu
	public void ToMenu (){
		SceneManager.LoadScene ("StartMenu");
	}

//------------------------------------------------------------------------------------------------------------------

	void Start (){
		Time.timeScale = 1;

	}

}
