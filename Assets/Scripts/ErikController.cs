using UnityEngine;
using System.Collections;


// Erikin ohjain
// Author: Jenna Kopra
using UnityEngine.SceneManagement;

public class ErikController : MonoBehaviour
{
	private ButtonController upButton;											// ylöspäinnappi
	private Animator animator;													// vaihtaa Erikin animaatioita
	public bool dead = false;													// boolean joka kertoo onko Erik kuollut vai ei
	private GameObject erik;													// Erikin hahmo
	private Rigidbody2D erikinkeho;												// Erikin keho



	void Start ()																//suorittaa ohjelman alussa
	{

		animator = GetComponent<Animator>();										// kertoo mikä on animatorin
		upButton = GameObject.Find ("UpButton").GetComponent<ButtonController> ();	// hakee upButtonin
		erik = GameObject.Find ("ErikPlayer");										// hakee erikin
		erikinkeho = GetComponent<Rigidbody2D>();									// hakee erikin kehon
	}


	void Update () {																// päivittää kerran framessa	

		if (dead == false) {														// boolean: jos erik ei ole kuollut, hahmo liikkuu eteenpäin
			erik.transform.Translate (0.20f, 0, 0);									// liikuttaa erikiä oikealla
		}
		if (upButton.GetPressed ()) {												// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
			MoveErik ("up");
		}
	}

	void MoveErik (string direction)												// Erikin hyppy
	{
	
	
		if (dead == false) {														// Boolean: suorittaa jos erik ei ole kuollut
	
			Debug.Log ("move " + direction);										// kertoo consolessa kun erik liikkuu ja minne


			if (direction.Equals ("up")) {
				erikinkeho.velocity = new Vector2(0, 10); 							// Erikin nousu
			}
				
		}

	}
	public void OnCollisionEnter2D (Collision2D coll)								// törmäyksen metodi
	{
		if (coll.gameObject.tag == "Enemy") {										// jos erik törmää objectiin jolle on määrätty tagi Enemy
		animator.SetInteger ("die", 3);												// suorittaa animaation "die"

		dead = true;																// boolean dead muuttuu trueksi
<<<<<<< HEAD
		Debug.Log ("Hit");															// kertoo consolessa "Hit"


=======
		Debug.Log ("Hit");
																	
		
>>>>>>> e9ccbd3465802ce9f7ad1d1a18951959109098cb
	}

}
}