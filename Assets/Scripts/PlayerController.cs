using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

//-----------Variables--------------------------------------------------------------------------------------------------------------

	private ButtonController upButton;
	private ButtonController downButton;
	public float jump;
	float moveVelocity;
	bool grounded = false;

//----------------------------------------------------------------------------------------------------------------------------------

	void Start (){
		upButton = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		downButton = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();
	}

//----------------------------------------------------------------------------------------------------------------------------------

	void Update () {

		// Hyppääminen
		if (upButton.GetPressed()){
			if (grounded){
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (
					GetComponent<Rigidbody2D> ().velocity.x, jump);

			}
		}
	}

//------------------------------------------------------------------------------------------------------------------------------------ 

	// Tarkistaa onko grounded vai ei
	void OnTriggerEnter2D(){
		grounded = true;
	}
	void OnTriggerExit2D(){
		grounded = false;
	}
}
