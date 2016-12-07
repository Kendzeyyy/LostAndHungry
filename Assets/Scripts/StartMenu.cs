using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* Author: Kendy Nguyen
 * This script is for the main menu which
 * you will see as soon when you open
 * the game. There is "Play", "Story",
 * "Levels" and "About" button.
 */


public class StartMenu : MonoBehaviour {


//------PlayButton--------------------------------------------------------------------------------------------------

	public void Play (){
		SceneManager.LoadScene ("dialog_level1");		

	}

//--------Story------------------------------------------------------------------------------------------------

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

//--------Levels----------------------------------------------------------------------------------------------------

	//LevelMenu
	public void LevelMenu (){
		SceneManager.LoadScene ("LevelMenu");
	}

	//LoadLevel2
	public void LevelMenu2 (){
		SceneManager.LoadScene ("LevelMenu2");
	}

	//LoadLevel3
	public void LevelMenu3 (){
		SceneManager.LoadScene ("LevelMenu3");
	}
				
	//Level 1
	public void level1 (){
		SceneManager.LoadScene ("Level1");
	}

	//level 1 Dialog
	public void level1DIalog (){
		SceneManager.LoadScene ("dialog_level1");
	}

	//Level 2
	public void level2 (){
		SceneManager.LoadScene ("Level2");
	}

	//level 2 Dialog
	public void level2Dialog (){
		SceneManager.LoadScene ("dialog_level2");
	}

	//Level 3
	public void level3 (){
		SceneManager.LoadScene ("Level3");
	}

	//level 3 Dialog
	public void level3Dialog (){
		SceneManager.LoadScene ("dialog_level3");
	}

	//Level 4
	public void level4 (){
		SceneManager.LoadScene ("Jet");
	}

	//level 4 Dialog
	public void level4Dialog (){
		SceneManager.LoadScene ("dialog_jet");
	}

	//Level 5
	public void level5 (){
		SceneManager.LoadScene ("level5");
	}

	//level 5 Dialog
	public void level5Dialog (){
		SceneManager.LoadScene ("dialog_level5");
	}

//---------About----------------------------------------------------------------------------------------------------

	//Load "About" scene
	public void about (){
		SceneManager.LoadScene ("About");
	}


//-------Dialog-----------------------------------------------------------------------------------------------------





//--------Start-----------------------------------------------------------------------------------------------------

	void Start (){
		Time.timeScale = 1;

	}

}
