using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

/*Author: Kendy Nguyen
 * DeathMenu class aktivoi "You Died" canvaksen
 * kun pelaaja törmää edessä olevaan
 * objektiin. Canvaksessa on "Restart" ja
 * "Main Menu" nappi.
 */


public class DeathMenu : MonoBehaviour {

//---------Variables--------------------------------------------------------------------------------------------------

	private ErikController hahmo;
	private GameObject background;
	private GameObject backgroundBoost;
	private GameObject backgroundJump;
	private GameObject backgroundCrouch;
	private Button nappi1;
	private Button nappi2;

//--------------------------------------------------------------------------------------------------------------------

	void Start () {

		background = GameObject.Find ("DeathMenu");
		backgroundJump = GameObject.Find ("UpButton");	
		backgroundCrouch = GameObject.Find ("DownButton");
		nappi1 = GameObject.Find ("PlayButton").GetComponent<Button>();
		nappi2 = GameObject.Find ("MenuButton").GetComponent<Button>();
		hahmo = GameObject.Find ("ErikPlayer").GetComponent<ErikController>();
		Debug.Log (background);

		nappi1.onClick.AddListener (()=> Restart ());
		nappi2.onClick.AddListener (()=> ToMenu ());
		background.SetActive (false);
	}

//--------------------------------------------------------------------------------------------------------------------

	void Update () {
		if (hahmo == null) {
			hahmo = GameObject.Find ("ErikPlayer").GetComponent<ErikController> ();
		} else {
			if (hahmo.dead)  {
				background.SetActive (true);
				backgroundJump.SetActive (false);
				backgroundCrouch.SetActive (false);
				Debug.Log ("aaaaaaaarggghhhhhh");
				Time.timeScale = 1;
			}
		}
	}

//--------------------------------------------------------------------------------------------------------------------

	public void Restart (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);		
		background.SetActive(true);

	}

//------------------------------------------------------------------------------------------------------------------

	public void ToMenu (){
		SceneManager.LoadScene ("StartMenu");

	}
}

//------------------------------------------------------------------------------------------------------------------