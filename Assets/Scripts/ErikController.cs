using UnityEngine;
using System.Collections;


// Erikin ohjain
// Author: Jenna Kopra
using UnityEngine.SceneManagement;

//----------------------------------------------------------------------------------------------------------------------------------------------------------------

public class ErikController : MonoBehaviour
{
	private ButtonController upButton;											// ylöspäinnappi
	private ButtonController downButton;										//
	private Animator animator;													// vaihtaa Erikin animaatioita
	public bool dead = false;													// boolean joka kertoo onko Erik kuollut vai ei
	private GameObject erik;													// Erikin hahmo
	public bool grounded = false;												//
	public float jump;															//
	private Rigidbody2D erikinkeho;												// Erikin keho
	public bool JumpLevel;														//
	public bool JetLevel;														//
	public float MovementSpeed;													//
	private CircleCollider2D objektiivi;										//

//--------Start----------------------------------------------------------------------------------------------------------------------------------------------------

	void Start ()																		//suorittaa ohjelman alussa
	{

		animator = GetComponent<Animator>();											// kertoo mikä on animatorin
		upButton = GameObject.Find ("UpButton").GetComponent<ButtonController> ();		// hakee upButtonin
		downButton = GameObject.Find ("DownButton").GetComponent<ButtonController> ();
		erik = GameObject.Find ("ErikPlayer");											// hakee erikin
		erikinkeho = GetComponent<Rigidbody2D>();										// hakee erikin kehon
		Time.timeScale = 1;
		objektiivi = GetComponent<CircleCollider2D> ();
	}

//--------Update---------------------------------------------------------------------------------------------------------------------------------------------------

	void Update () {																	// päivittää kerran framessa	

		Debug.Log (Physics.gravity);

		if (dead == false) {			 												// boolean: jos erik ei ole kuollut, hahmo liikkuu eteenpäin
			erikinkeho.velocity = new Vector2(MovementSpeed, erikinkeho.velocity.y);
			animator.SetInteger ("crouch", 1);// liikuttaa erikiä oikealla
		}

		if (upButton.GetPressed ()) {													// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
			MoveErik ("up");

		}
		if (downButton.GetPressed ()) {													// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
			MoveErik ("down");

		} else {
			objektiivi.offset = new Vector2 (objektiivi.offset.x, -12);
		}
	}

//----------MoveErik----------------------------------------------------------------------------------------------------------------------------------------------

	void MoveErik (string direction)													// Erikin hyppy
	{
		
		if (dead == false) {															// Boolean: suorittaa jos erik ei ole kuollut
			Debug.Log ("move " + direction);											// kertoo consolessa kun erik liikkuu ja minne

			if (direction.Equals ("up") && JetLevel) {
				erikinkeho.AddForce (transform.up * 500);	

			}

			if (direction.Equals ("up") && grounded && JumpLevel) {
				Debug.Log ("Hypppppyyyyy");
				erikinkeho.AddForce (new Vector2 (5, 1 * jump));
				grounded = false;
			}

			if (direction.Equals ("down") && grounded && JumpLevel) {
				animator.SetInteger ("crouch", 4);	
				objektiivi.offset = new Vector2 (objektiivi.offset.x, -9);

			}
		}
	}

//----------Colliding------------------------------------------------------------------------------------------------------------------------------------------

	void OnCollisionEnter2D (Collision2D coll)											// törmäyksen metodi
	{
		Debug.Log ("test");
		if (coll.gameObject.tag == "Enemy") {											// jos erik törmää objectiin jolle on määrätty tagi Enemy
		animator.SetInteger ("die", 3);													// suorittaa animaation "die"

		dead = true;																	// boolean dead muuttuu trueksi

		Debug.Log ("Hit");																// kertoo consolessa "Hit"
		GetComponent<RespectCounter> ().OnDeath ();

	}
		if (coll.gameObject.tag == "Ground") {
			Debug.Log ("toimii");
			grounded = true;
		
		}
	}

		void OnTriggerEnter2D ()
		{																			// tarkistaa onko hahmo maassa
			grounded = true;														// jos on maassa niin grounded arvo on true
		}

		void OnTriggerExit2D ()
		{																			// tarkistaa onko hahmo maassa
			grounded = false;														// jos ei ole maassa niin grounded arvo on false
	}
}

