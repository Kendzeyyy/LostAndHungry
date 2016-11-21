using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	private ButtonController upButton;
	private ButtonController downButton;
	private GameObject erik;
	private BallController pelaaja;
	public float objectspeed = 0.2f;
	public float gravity = -5f;

	// Use this for initialization
	void Start (){
		upButton = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		downButton = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();
		pelaaja = FindObjectOfType<BallController> ();
		erik = GameObject.Find ("erik");

	}

	// Update is called once per frame
	void Update (){

		pelaaja.playerMove();
		if (upButton.GetPressed ()) {
			MoveErik ("up");
		}
		if (downButton.GetPressed ()){
			MoveErik ("down");
		}
	}

	void MoveErik (string direction)
	{
		//("move " + direction);
		if (direction.Equals ("up")) {
			pelaaja.playerJump ();
			//erik.transform.Translate (0, objectspeed, 0);
		}

		if (direction.Equals ("down")) {
			erik.transform.Translate (0, -objectspeed, 0);

		}
	}
}
