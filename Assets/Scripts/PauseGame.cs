using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

/* Author: Kendy Nguyen
 * Tämä script keskeyttää pelin painamalla
 * Pause logoa vasemmasta ylänurkasta.
 * Koodi asettaa pelin ajaksi 0
 * ja tulostaa canvaksen näytölle missä
 * on pause menu.
 */ 

public class PauseGame : MonoBehaviour {

//----------Variables--------------------------------------------------------------------------------------------------------------------------------------------

	public Button pause;													// pause
	public Button resume;													// resume
	private GameObject tausta;												// tausta
	private GameObject taustaUp;											// taustaUp
	private GameObject taustaDown;											// taustaDown
	private GameObject erikMate;											// erikMate
	private GameObject enemies;												// enemies
	public bool esimerkki = false;											// bool esimerkki

//-----------Start-----------------------------------------------------------------------------------------------------------------------------------------------

	void Start (){
		
		tausta = GameObject.Find ("Pause Background");						// 
		taustaUp = GameObject.Find ("UpButton");							//
		taustaDown = GameObject.Find ("DownButton");						//
		erikMate = GameObject.Find ("ErikPlayer");							//
		enemies = GameObject.Find ("AllEnemies");							//
		pause = GameObject.Find ("PauseLogo").GetComponent<Button> ();		// 
		resume = GameObject.Find ("Resume").GetComponent<Button> ();		//										
		Debug.Log (tausta);

		pause.onClick.AddListener(()=> Pause());							// 
		resume.onClick.AddListener(()=> Pause());							// 
		tausta.SetActive (false);											//
		taustaUp.SetActive (true);											//

	}

//----------Update------------------------------------------------------------------------------------------------------------------------------------------------

	void Update(){
		if (esimerkki)														// jos (esimerkki)
		{
								
			tausta.SetActive(true);											// tausta.SetACtive (Canvas) on tosi eli pause menu on päällä
			taustaUp.SetActive(false);										// 				
			taustaDown.SetActive(false);
			Time.timeScale = 0;												// asettaa pelin ympäristölle ajaksi 0
		}

		else  																// muuten
		{									
			tausta.SetActive(false);										// tausta.SetACtive (Canvas) on epätosi eli pause menu menee pois päältä
			taustaUp.SetActive(true);										// 
			taustaDown.SetActive(true);
			Time.timeScale = 1;												// asettaa pelin ympäristölle ajaksi 1 eli normaali aika
		}	
	}


//-----------Pause------------------------------------------------------------------------------------------------------------------------------------------------

	public void Pause(){
		esimerkki = !esimerkki;												//
	}


	public void Restart (){
		Time.timeScale = 1;													// asettaa ajaksi 1 sen jälkeen kun pause menu on sulkeutunut
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);		// lataa scenen uudestaan
	}

	public void MainMenu (){												
		SceneManager.LoadScene ("StartMenu");								// lataa "StartMenu" scenen
	}
}

