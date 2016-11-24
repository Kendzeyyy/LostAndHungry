using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {

	//----------Variables-----------------------------------------------------------------------------------------------------------------------------------------

	public Button pause;													// pause nappi
	private GameObject tausta;												// peli objekti tausta
	bool esimerkki = false;													// esimerkki boolean arvo = false

	//-----------Start--------------------------------------------------------------------------------------------------------------------------------------------

	void Start (){
		tausta = GameObject.Find ("Canvas");								// etsii Unity ohjelmasta "Canvasta"
		tausta.SetActive (false);											// kun peli käynistyy, asettaa canvaksen pois päältä
		pause = GameObject.Find ("PauseLogo").GetComponent<Button> ();		// etsii Unity ohjelmasta "PauseLogo"
		Debug.Log (pause);													// 
		pause.onClick.AddListener(()=> Pause());							// 
	}

	//-----------Update-------------------------------------------------------------------------------------------------------------------------------------------

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))								// jos painaa kerran "Esc"
		{
			Pause();														// ohjelma pysähtyy
		}
	}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------

	public void Pause()
	{
		if (esimerkki)														// jos (esimerkki)
		{
			esimerkki = !esimerkki;											// esimerkki = epätosi esimerkki
			tausta.SetActive(true);											// tausta.SetACtive (Canvas) on tosi eli pause menu on päällä
			Time.timeScale = 0;												// asettaa pelin ympäristölle ajaksi 0 eli kaikki pysähtyy paitsi musiikki
		}

		else  																// muuten
		{
			esimerkki = !esimerkki;											// esimerkki = epätosi esimerkki
			tausta.SetActive(false);										// tausta.SetACtive (Canvas) on epätosi eli pause menu menee pois päältä
			Time.timeScale = 1;												// asettaa pelin ympäristölle ajaksi 1 eli normaali aika
		}																	// Jos arvoksi asettaa esim. 2 niin peli on 2x nopeampi kuin normaalisti
	}
}
