using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

/*Author: Kendy Nguyen
 * DeathMenu will activate "You Died" canvas
 * when you die. Canvas has "Play" button which
 * will restart the game and "Menu" button
 * which goes to main menu.
 */


public class DeathMenu : MonoBehaviour {

	//---------Variables--------------------------------------------------------------------------------------------------

	private ErikController hahmo;														// hahmo
	private GameObject pauseMenu;														// pauseMenu
	private GameObject pauseIcon;														// pauseIcon
	private GameObject background;														// background
	private GameObject backgroundBoost;													// backgroundBoost
	private GameObject backgroundJump;													// backgroundJump
	private GameObject backgroundCrouch;												// backgroundCrouch
	private GameObject respect;															// respect
	private GameObject score;															// score
	private Button nappi1;																// nappi1
	private Button nappi2;																// nappi2
	public Text scoreText;

	//--------------------------------------------------------------------------------------------------------------------

	void Start () {

		background = GameObject.Find ("DeathMenu");										// background 		=	DeathMenu
		pauseMenu = GameObject.Find ("PauseBackground");								// pauseMenu 		=	PauseBackGround
		pauseIcon = GameObject.Find ("PauseIcon");										// pauseIcon		=	PauseIcon
		backgroundJump = GameObject.Find ("UpButton");									// backgroundJump 	=	UpButton
		backgroundCrouch = GameObject.Find ("DownButton");								// backgroundCrouch =	DownButton
		respect = GameObject.Find ("Respect");											// respect			=	Respect
		score = GameObject.Find ("Score");												// score			=	Score
		nappi1 = GameObject.Find ("PlayButton").GetComponent<Button>();					// nappi1			=	PlayButton
		nappi2 = GameObject.Find ("MenuButton").GetComponent<Button>();					// nappi2			=	MenuButton
		hahmo = GameObject.Find ("ErikPlayer").GetComponent<ErikController>();			// hahmo			=	ErikPlayer
		Debug.Log (background);															// Debug.Log		=	DeathMenu

		nappi1.onClick.AddListener (()=> Restart ());									// PlayButton => LoadScene.name
		nappi2.onClick.AddListener (()=> ToMenu ());									// MenuButton => LoadScene.StartMenu
		background.SetActive (false);													// DeathMenu.SetActive (off)
	}

	//--------------------------------------------------------------------------------------------------------------------

	void Update () {
		if (hahmo == null) {															// 
			hahmo = GameObject.Find ("ErikPlayer").GetComponent<ErikController> ();		// hahmo = ErikPlayer
		} else {																		// 
			if (hahmo.dead)  {															// ErikPlayer.dead
				background.SetActive (true);											// DeathMenu.SetActive 			(on)
				pauseIcon.SetActive (false);											// PauseIcon.SetActive			(off)
				pauseMenu.SetActive (false);											// PauseBackground.SetActive	(off)
				backgroundJump.SetActive (false);										// UpButton.SetActive			(off)
				backgroundCrouch.SetActive (false);										// DownButton.SetActive			(off)
				respect.SetActive (false);												// Respect.SetActive			(off)
				score.SetActive (false);												// Score.SetActive				(off)
				Debug.Log ("aaaaaaaarggghhhhhh");										// Debug.Log
				Time.timeScale = 1;														// Time set to 1
			}
		}
	}

	//--------------------------------------------------------------------------------------------------------------------

	public void Restart (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);					// LoadScene = Level.name
	}

	//------------------------------------------------------------------------------------------------------------------

	public void ToMenu (){
		SceneManager.LoadScene ("StartMenu");											// LoadScene = StartMenu
	}

	//------------------------------------------------------------------------------------------------------------------

	//Author: Mikael Ahlström
	public void ToggleEndScore (float score) {
		scoreText.text = ((int)score).ToString ();
	}
}