using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

/* Author: Kendy Nguyen
 * This script will pause the game
 * by pressing "PauseLogo". PauseGame
 * script will freeze player and enemies
 * and animations and print out pause canvas.
 * Pause canvas has "Resume", "Restart"
 * and "Main Menu" buttons.
 */ 

public class PauseGame : MonoBehaviour {

	//----------Variables--------------------------------------------------------------------------------------------------------------------------------------------
	public Button next;
	public Button pause;													// pause
	public Button resume;													// resume
	private GameObject respect;												// respect
	private GameObject score;												// score
	private GameObject tausta;												// tausta
	private GameObject taustaUp;											// taustaUp
	private GameObject taustaDown;											// taustaDown
	private GameObject erikMate;											// erikMate
	private GameObject enemies;												// enemies
	public bool esimerkki = false;											// bool esimerkki

	//-----------Start-----------------------------------------------------------------------------------------------------------------------------------------------

	void Start (){

		tausta = GameObject.Find ("Pause Background");						// tausta		=	PauseBackground
		taustaUp = GameObject.Find ("UpButton");							// taustaUp		=	UpButton
		taustaDown = GameObject.Find ("DownButton");						// taustaDown	=	DownButtoon
		respect = GameObject.Find ("Respect");								// respect		=	Respect
		score = GameObject.Find ("Score");									// score		=	Score
		erikMate = GameObject.Find ("ErikPlayer");							// erikMate		=	ErikPlayer
		enemies = GameObject.Find ("AllEnemies");							// enemies		=	AllEnemies
		pause = GameObject.Find ("PauseLogo").GetComponent<Button> ();		// pause		=	PauseLogo
		resume = GameObject.Find ("Resume").GetComponent<Button> ();		// resume		=	Resume			
		Debug.Log (tausta);													// Debug.Log	=	PauseBackground

		pause.onClick.AddListener(()=> Pause());							// PauseLogo => Pause
		resume.onClick.AddListener(()=> Pause());							// Resume => !Pause
		tausta.SetActive (false);											// PauseBackground.SetActive (off)

	}

	//----------Update------------------------------------------------------------------------------------------------------------------------------------------------

	void Update(){
		if (esimerkki)														// boolean
		{					
			tausta.SetActive(true);											// PauseBackground	(on)
			taustaUp.SetActive(false);										// UpButton			(off)
			taustaDown.SetActive(false);									// DownButton		(off)
			respect.SetActive (false);										// Respect			(off)
			score.SetActive (false);										// Score			(off)
			Time.timeScale = 0;												// Time set to 0
			AudioListener.pause = true;
		}

		else  																// else
		{									
			tausta.SetActive(false);										// PauseBackground	(off)
			taustaUp.SetActive(true);										// UpButton			(on)
			taustaDown.SetActive(true);										// DownButton		(on)
			respect.SetActive (true);										// Respect			(on)
			score.SetActive (true);											// Score			(on)
			Time.timeScale = 1;												// Time set to 1
			AudioListener.pause = false;
		}	
	}


	//-----------Pause------------------------------------------------------------------------------------------------------------------------------------------------

	public void Pause(){
		esimerkki = !esimerkki;												// boolean = !boolean
	}

	public void Restart (){
		Time.timeScale = 1;													// Time set to 1
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);		// LoadScene = Level.name
	}

	public void MainMenu (){												
		SceneManager.LoadScene ("StartMenu");								// LoadScene = StartMenu
	}
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------