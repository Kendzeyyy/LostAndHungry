using UnityEngine;
using System.Collections;

public class erikJump : ButtonController {
	private ButtonController upButton;
	private ButtonController downButton;// ylöspäinnappi
	private Animator animator;													// vaihtaa Erikin animaatioita
	public bool dead = false;													// boolean joka kertoo onko Erik kuollut vai ei
	private GameObject erik;
	bool grounded = false;	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();										// kertoo mikä on animatorin	// hakee upButtonin
		erik = GameObject.Find ("ErikPlayer");
		upButton = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();				// etsii "ButtonUp" Unity ohjelmasta
		downButton = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();	
	}
	
	// Update is called once per frame
	void Update () {																// päivittää kerran framessa	

		if (dead == false) {
			// boolean: jos erik ei ole kuollut, hahmo liikkuu eteenpäin
			erik.transform.Translate (5f, 0, 0);									// liikuttaa erikiä oikealla
		}
			if (upButton.GetPressed ()) {												// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
				MoveErik ("up");

			}
			if (downButton.GetPressed ()) {												// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
				MoveErik ("down");

			}
		
	}
	void OnTriggerEnter2D(){																	// tarkistaa onko hahmo maassa
		grounded = true;																		// jos on maassa niin grounded arvo on true
	}
	void OnTriggerExit2D(){																		// tarkistaa onko hahmo maassa
		grounded = false;																		// jos ei ole maassa niin grounded arvo on false
	}	

	void MoveErik (string direction)												// Erikin hyppy
	{


		if (dead == false) {														// Boolean: suorittaa jos erik ei ole kuollut

			Debug.Log ("move " + direction);										// kertoo consolessa kun erik liikkuu ja minne


			if (direction.Equals ("up")) {
				erik.transform.Translate (0, 5f, 0);													// Erikin nousu
			}
			if (direction.Equals ("down")) {
				animator.SetInteger ("crouch", 4);	
				erik.transform.Translate (0, -1f, 0);
				animator.SetInteger ("noCrouch", 7);
				// Erikin nousu
			}

		}

	}
	void OnCollisionEnter2D (Collision2D coll)											// törmäyksen metodi
	{
		Debug.Log ("test");
		if (coll.gameObject.tag == "Enemy") {										// jos erik törmää objectiin jolle on määrätty tagi Enemy
			animator.SetInteger ("die", 3);												// suorittaa animaation "die"

			dead = true;																// boolean dead muuttuu trueksi

			Debug.Log ("Hit");															// kertoo consolessa "Hit"

		}

	}


																						// tämä estää pelaajan hyppäävän ilmassa
}

