using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartMenu : MonoBehaviour {


//------PlayButton--------------------------------------------------------------------------------------------------

	public void Play (){
		SceneManager.LoadScene ("Jet");		// lataa scenen

	}

//--------TextButton------------------------------------------------------------------------------------------------

	public void Story (){
		SceneManager.LoadScene ("StoryText");
	}

	public void StoryTwo (){
		SceneManager.LoadScene ("StoryText2");
	}

	public void StoryThree (){
		SceneManager.LoadScene ("StoryText3");
	}

	public void StoryFour (){
		SceneManager.LoadScene ("StoryText4");
	}

//------------------------------------------------------------------------------------------------------------------

	void Start (){
		Time.timeScale = 1;

	}

}
