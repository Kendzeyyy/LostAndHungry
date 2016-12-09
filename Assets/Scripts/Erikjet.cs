using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;


//Erik's controller in the jet level
// Author: Jenna Kopra

public class Erikjet : MonoBehaviour
{
	private ButtonController upButton;											
	private Animator animator;													
	public bool dead = false;													
	private GameObject erik;													
	private Rigidbody2D erikinkeho;												
	public float MovementSpeed;			

	void Start ()																	

		animator = GetComponent<Animator>();										// get animator
		upButton = GameObject.Find ("UpButton").GetComponent<ButtonController> ();	// gets upButton
		erik = GameObject.Find ("ErikPlayer");										// gets Erik
		erikinkeho = GetComponent<Rigidbody2D>();									// gets erikinkehon
	}


	void Update () {																	

		if (dead == false) {															// boolean: if erik is not dead, he gpes forward
			erikinkeho.velocity = new Vector2 (MovementSpeed, erikinkeho.velocity.y);		// moves erik to the right
		
		if (upButton.GetPressed ()) {													// if upbutton is pressed, code does the MoveErik's "Up"
				MoveErik ("up");
			}
		}
	}
	
	void MoveErik (string direction)													// Erik's jump
	{


		if (dead == false) {															// if erik is not dead

			Debug.Log ("move " + direction);											


			if (direction.Equals ("up")) {
				
				erikinkeho.AddForce (transform.up * 800);								// Erik's goes higher
			}

		}

	}
public void OnCollisionEnter2D (Collision2D coll)										// hitting method
	{
	if (coll.gameObject.tag == "Enemy") {												// if erik hits an object tagged enemy
		animator.SetInteger ("die", 3);													// does the die animation

			dead = true;																
			Debug.Log ("Hit");															

			GetComponent<RespectCounterJet>().OnDeath();								// gets respect counter

		}

	}
}