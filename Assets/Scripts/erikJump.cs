using UnityEngine;
using System.Collections;

public class erikJump : ButtonController {
	private ButtonController upButton;
	private ButtonController downButton;// ylöspäinnappi
	private Animator animator;													// vaihtaa Erikin animaatioita
	public bool dead = false;													// boolean joka kertoo onko Erik kuollut vai ei
	private GameObject erik;
	public bool grounded = false;
	private Rigidbody2D keho;	
	public float jump;	



	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();										// kertoo mikä on animatorin	// hakee upButtonin
		erik = GameObject.Find ("ErikPlayer");
		upButton = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();				// etsii "ButtonUp" Unity ohjelmasta
		downButton = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();
		keho = GetComponent<Rigidbody2D>();		
	}
	
	// Update is called once per frame
	void Update () {																// päivittää kerran framessa	

		if (dead == false) {
			// boolean: jos erik ei ole kuollut, hahmo liikkuu eteenpäin
			erik.transform.Translate (30f, 0, 0);
			animator.SetInteger ("crouch", 1);// liikuttaa erikiä oikealla
		}
		if (upButton.GetPressed ()) {
			 
				// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
				MoveErik ("up");

			}


			if (downButton.GetPressed ()) {												// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
				MoveErik ("down");

			}
		}



	void MoveErik (string direction)												// Erikin hyppy
	{


		if (dead == false) {														// Boolean: suorittaa jos erik ei ole kuollut

			Debug.Log ("move " + direction);										// kertoo consolessa kun erik liikkuu ja minne


			if (direction.Equals ("up") && (grounded==true)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (							// hakee component liikkumisvauhti = Vector2
			GetComponent<Rigidbody2D> ().velocity.x, jump);
			grounded = false;// Erikin nousu
			}
			if (direction.Equals ("down") && (grounded==true)) {
				animator.SetInteger ("crouch", 4);	
				keho.velocity = new Vector2(0, -50f); 	

				// Erikin nousu
			}

		}

	}
	void OnCollisionEnter2D (Collision2D coll)											// törmäyksen metodi
	{
		Debug.Log ("test");
		if (coll.gameObject.tag == "Ground") {
			Debug.Log ("toimii");
			grounded = true;

		}
		if (coll.gameObject.tag == "Enemy") {										// jos erik törmää objectiin jolle on määrätty tagi Enemy
			animator.SetInteger ("die", 3);												// suorittaa animaation "die"

			dead = true;																// boolean dead muuttuu trueksi

			Debug.Log ("Hit");															// kertoo consolessa "Hit"

		}

	}

	void OnTriggerEnter2D(){																	// tarkistaa onko hahmo maassa
		grounded = true;																		// jos on maassa niin grounded arvo on true
	}
	void OnTriggerExit2D(){																		// tarkistaa onko hahmo maassa
		grounded = false;																		// jos ei ole maassa niin grounded arvo on false
	}	
																					// tämä estää pelaajan hyppäävän ilmassa
}

