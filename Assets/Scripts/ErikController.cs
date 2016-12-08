using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


// Erikin ohjain. 
// Author: Jenna Kopra


//----------------------------------------------------------------------------------------------------------------------------------------------------------------

public class ErikController : MonoBehaviour
{
	private ButtonController upButton;
	private ButtonController downButton;
	private Animator animator;
	public bool dead = false;
	private GameObject erik;
	public bool grounded = false;
	public float jump;
	private Rigidbody2D erikinkeho;
	public bool JumpLevel;
	public bool JetLevel;
	public float MovementSpeed;
	private CircleCollider2D objektiivi;

	//--------Start----------------------------------------------------------------------------------------------------------------------------------------------------

	void Start ()																		//suorittaa ohjelman alussa
	{

		animator = GetComponent<Animator> ();											// kertoo mikä on animatorin
		upButton = GameObject.Find ("UpButton").GetComponent<ButtonController> ();		// hakee upButtonin
		downButton = GameObject.Find ("DownButton").GetComponent<ButtonController> ();	// hakee DownButtonin
		erik = GameObject.Find ("ErikPlayer");											// hakee erikin
		erikinkeho = GetComponent<Rigidbody2D> ();										// hakee erikin kehon
		Time.timeScale = 1;																// aika
		objektiivi = GetComponent<CircleCollider2D> ();									// hakee colliderin
	}

	//--------Update---------------------------------------------------------------------------------------------------------------------------------------------------

	void Update ()
	{																		

		Debug.Log (Physics.gravity);

		if (dead == false) {			 												// jos erik ei ole kuollut, hahmo liikkuu eteenpäin
			erikinkeho.velocity = new Vector2 (MovementSpeed, erikinkeho.velocity.y);	// liikuttaa erikiä oikealla
			animator.SetInteger ("crouch", 1);											// juoksuanimaatio
		}

		if (upButton.GetPressed () || Input.GetKeyDown (KeyCode.W)) {					// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
			MoveErik ("up");															//

		}
		if (downButton.GetPressed () || Input.GetKeyDown (KeyCode.S)) {					// jos painetaan upButtonnia,suoritetaan MoveErikin "Up"
			MoveErik ("down");															//

		} else {
			objektiivi.offset = new Vector2 (objektiivi.offset.x, -12);					// collider
		}
	}

	//----------MoveErik----------------------------------------------------------------------------------------------------------------------------------------------

	void MoveErik (string direction)													// Erikin hyppy
	{
		
		if (dead == false) {															// Boolean: suorittaa jos erik ei ole kuollut
			Debug.Log ("move " + direction);											

			if (direction.Equals ("up") && JetLevel) {									// hyppää ylöspäin jetissä
				erikinkeho.AddForce (transform.up * 500);	

			}

			if (direction.Equals ("up") && grounded && JumpLevel) {						// hyppää ylöspäin
				Debug.Log ("Hypppppyyyyy");
				animator.SetInteger ("jump", 7);	

				erikinkeho.AddForce (new Vector2 (5, 1 * jump));
				grounded = false;
			
			}

			if (direction.Equals ("down") && grounded && JumpLevel) {					//crouchaa
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

			dead = true;																	

			Debug.Log ("Hit");																
			GetComponent<RespectCounter> ().OnDeath ();

		}
		if (coll.gameObject.tag == "Ground") {											// erik osuu maahan
			animator.SetInteger ("jump", 6);											// animaatio palautuu juoksuksi
			Debug.Log ("toimii");
			grounded = true;
		
		}
	}

	//-------------------------------------------------------------------------------------------------------------------------------------------------------------

	void OnTriggerEnter2D ()															// tarkistaa onko hahmo maassa
	{																			
		grounded = true;
	}

	void OnTriggerExit2D ()
	{		
		grounded = false;
	}
}

