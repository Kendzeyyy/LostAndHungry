using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


// Erik's controller 
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

	void Start ()																		
	{

		animator = GetComponent<Animator> ();											// gets animator
		upButton = GameObject.Find ("UpButton").GetComponent<ButtonController> ();		// gets upButton
		downButton = GameObject.Find ("DownButton").GetComponent<ButtonController> ();	// gets DownButton
		erik = GameObject.Find ("ErikPlayer");											// gets erik
		erikinkeho = GetComponent<Rigidbody2D> ();										// gets erikinkehon
		Time.timeScale = 1;																// real time
		objektiivi = GetComponent<CircleCollider2D> ();									// gets collider
	}

	//--------Update---------------------------------------------------------------------------------------------------------------------------------------------------

	void Update ()
	{																		

		Debug.Log (Physics.gravity);

		if (dead == false) {			 												// if erik is not dead, he moves forward
			erikinkeho.velocity = new Vector2 (MovementSpeed, erikinkeho.velocity.y);	// moves erik to the right
			animator.SetInteger ("crouch", 1);											// running animation
		}

		if (upButton.GetPressed () || Input.GetKeyDown (KeyCode.W)) {					// if upbutton is pressed, code does the MoveErik's "Up"
			MoveErik ("up");															//

		}
		if (downButton.GetPressed () || Input.GetKeyDown (KeyCode.S)) {					// If down button is pressed, the code does the MoveErik's "Down"
			MoveErik ("down");															//

		} else {
			objektiivi.offset = new Vector2 (objektiivi.offset.x, -12);					// collider
		}
	}

	//----------MoveErik----------------------------------------------------------------------------------------------------------------------------------------------

	void MoveErik (string direction)													// Erik's jump
	{
		
		if (dead == false) {															// Boolean: if Erik's is not dead
			Debug.Log ("move " + direction);											

			if (direction.Equals ("up") && JetLevel) {									// goes up with jetpack
				erikinkeho.AddForce (transform.up * 500);	

			}

			if (direction.Equals ("up") && grounded && JumpLevel) {						// jumps
				Debug.Log ("Hypppppyyyyy");
				animator.SetInteger ("jump", 7);	

				erikinkeho.AddForce (new Vector2 (5, 1 * jump));
				grounded = false;
			
			}

			if (direction.Equals ("down") && grounded && JumpLevel) {					//crouches
				animator.SetInteger ("crouch", 4);	
				objektiivi.offset = new Vector2 (objektiivi.offset.x, -9);

			}
		}
	}

	//----------Colliding------------------------------------------------------------------------------------------------------------------------------------------

	void OnCollisionEnter2D (Collision2D coll)											// hitting method
	{
		Debug.Log ("test");
		if (coll.gameObject.tag == "Enemy") {											// if erik hits an object tagged enemy
			animator.SetInteger ("die", 3);													// does the die animation

			dead = true;																	

			Debug.Log ("Hit");																
			GetComponent<RespectCounter> ().OnDeath ();

		}
		if (coll.gameObject.tag == "Ground") {											// erik hits the floor
			animator.SetInteger ("jump", 6);											// animation returns to running
			Debug.Log ("toimii");
			grounded = true;
		
		}
	}

	//-------------------------------------------------------------------------------------------------------------------------------------------------------------

	void OnTriggerEnter2D ()															// checks if the character is grounded
	{																			
		grounded = true;
	}

	void OnTriggerExit2D ()
	{		
		grounded = false;
	}
}

