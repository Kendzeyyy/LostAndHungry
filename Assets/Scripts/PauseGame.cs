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

	public Button pause;													// pause nappi
	public Button resume;
	private GameObject tausta;												// peli objekti tausta
	bool esimerkki = false;													// esimerkki boolean arvo = false

//-----------Start-----------------------------------------------------------------------------------------------------------------------------------------------

	void Start (){
		tausta = GameObject.Find ("Pause Background");						// etsii Unity ohjelmasta "Canvasta"
		pause = GameObject.Find ("PauseLogo").GetComponent<Button> ();		// etsii Unity ohjelmasta "PauseLogo"
		resume = GameObject.Find ("Resume").GetComponent<Button> ();											
		Debug.Log(tausta);
		pause.onClick.AddListener(()=> Pause());							// Pause nappia painatessa => Pause
		resume.onClick.AddListener(()=> Pause());
		tausta.SetActive (false);
	}


	void Update(){
		if (esimerkki)														// jos (esimerkki)
		{
								
			tausta.SetActive(true);											// tausta.SetACtive (Canvas) on tosi eli pause menu on päällä
			Time.timeScale = 0;												// asettaa pelin ympäristölle ajaksi 0 eli kaikki pysähtyy paitsi musiikki
		}

		else  																// muuten
		{									
			tausta.SetActive(false);										// tausta.SetACtive (Canvas) on epätosi eli pause menu menee pois päältä
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
