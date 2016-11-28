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

	private GameObject background;



//--------------------------------------------------------------------------------------------------------------------

	void Start () {
		background = GameObject.Find ("Canvas");
		background.SetActive (true);
	}

//--------------------------------------------------------------------------------------------------------------------

	void Update () {
		
	}

//--------------------------------------------------------------------------------------------------------------------

	public void ToggleEndMenu (){
		gameObject.SetActive (true);
	}

//-------------------------------------------------------------------------------------------------------------------

	public void Restart (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);		// lataa scenen
		background.SetActive(true);

	}

//------------------------------------------------------------------------------------------------------------------

	public void ToMenu (){
		SceneManager.LoadScene ("StartMenu");

	}
	
//------------------------------------------------------------------------------------------------------------------

}
