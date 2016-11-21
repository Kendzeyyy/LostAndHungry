using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jump;
	float moveVelocity;
	bool grounded = false;
	

	void Update () {

		// Hyppääminen
		if (Input.GetKeyDown(KeyCode.Space)){
			if (grounded){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (
				GetComponent<Rigidbody2D> ().velocity.x, jump);

		}
	}
}	

	 //Tarkistaa onko grounded vai ei
	void OnTriggerEnter2D(){
		grounded = true;
	}
	void OnTriggerExit2D(){
		grounded = false;
	}

}
