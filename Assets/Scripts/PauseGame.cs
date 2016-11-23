using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {

	//----------Variables-----------------------------------------------------------------------------------------------------

	public Button pause;
	private GameObject tausta;
	bool esimerkki = false;

	//-----------Start-------------------------------------------------------------------------------------------------------

	void Start (){
		tausta = GameObject.Find ("Canvas");
		tausta.SetActive (false);
		pause = GameObject.Find ("PauseLogo").GetComponent<Button> ();
		Debug.Log (pause);
		pause.onClick.AddListener(()=> Pause());
	}

	//-----------Update-------------------------------------------------------------------------------------------------------

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
	}

	//------------------------------------------------------------------------------------------------------------------------

	public void Pause()
	{
		if (esimerkki)
		{
			esimerkki = !esimerkki;
			tausta.SetActive(true);
			Time.timeScale = 0;
		}

		else
		{
			esimerkki = !esimerkki;
			tausta.SetActive(false);
			Time.timeScale = 1;
		}
	}
}
