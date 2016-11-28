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
	private ErikController hahmo;
	private Button nappi1;
	private Button nappi2;


//--------------------------------------------------------------------------------------------------------------------

	void Start () {
<<<<<<< HEAD
		background = GameObject.Find ("DeathMenu");
		nappi1 = GameObject.Find ("PlayButton").GetComponent<Button>();
		nappi2 = GameObject.Find ("MenuButton").GetComponent<Button>();
		nappi1.onClick.AddListener (() => Restart ());
		nappi2.onClick.AddListener (() => ToMenu ());
		background.SetActive (false);
		hahmo = GameObject.Find ("ErikPlayer").GetComponent<ErikController>();

=======
		background = GameObject.Find ("Canvas");
		background.SetActive (true);
>>>>>>> e9ccbd3465802ce9f7ad1d1a18951959109098cb
	}

//--------------------------------------------------------------------------------------------------------------------

	void Update () {
		if (hahmo.dead) {
			background.SetActive (true);
			Debug.Log (hahmo);
		}
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
