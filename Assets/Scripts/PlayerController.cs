using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

//-----------Variables--------------------------------------------------------------------------------------------------------------

	private ButtonController upButton;															// nappiYlös
	private ButtonController downButton;														// nappiAlas
	public float jump;																			// hyppy
	float moveVelocity;																			// liikkumisnopeus
	bool grounded = false;																		// bool grounded arvo false

//-----------Start------------------------------------------------------------------------------------------------------------------

	void Start (){																				// alkaa heti kun käynnistää pelin
		upButton = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();				// etsii "ButtonUp" Unity ohjelmasta
		downButton = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();			// etsii "ButtonDown" Unity ohjelmasta
	}

//-----------Update-----------------------------------------------------------------------------------------------------------------

	void Update () {

		// Hyppääminen
		if (upButton.GetPressed()){																// jos upButton eli "ButtonUp" painetaan
			if (grounded){																		// jos grounded = false
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (							// hakee component liikkumisvauhti = Vector2
					GetComponent<Rigidbody2D> ().velocity.x, jump);								// liikkumisvauhti x suunnassa, hyppy

			}
		}
	}

//------------------------------------------------------------------------------------------------------------------------------------ 

	// Tarkistaa onko grounded vai ei
	void OnTriggerEnter2D(){																	// tarkistaa onko hahmo maassa
		grounded = true;																		// jos on maassa niin grounded arvo on true
	}
	void OnTriggerExit2D(){																		// tarkistaa onko hahmo maassa
		grounded = false;																		// jos ei ole maassa niin grounded arvo on false
	}
}
