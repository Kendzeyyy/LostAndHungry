using UnityEngine;
using System.Collections;

public class ErikController : MonoBehaviour
{
	private ButtonController upButton;
	private ButtonController downButton;
	private Animator animator;
	public float erikSpeed;

	private GameObject erik;

	void awake() {
		animator = GetComponent<Animator>();
		// Use this for initialization
	}
	void OnCollisionEnter2D (Collision2D coll)
	{
		animator.SetInteger ("die", 1);
		Debug.Log ("Hit");

	}

	void Start ()
	{
		
		downButton = GameObject.Find ("DownButton").GetComponent<ButtonController> ();
		upButton = GameObject.Find ("UpButton").GetComponent<ButtonController> ();
		erik = GameObject.Find ("ErikPlayer");

	}

	// Update is called once per frame
	void Update ()
	{
		erik.transform.Translate (0.05f, 0, 0);
		if (upButton.GetPressed ()) {
			MoveErik ("up");
		}
		if (downButton.GetPressed ()) {
			MoveErik ("down");
		}
	}

	void MoveErik (string direction)
	{
		Debug.Log ("move " + direction);


		if (direction.Equals ("up")) {
			erik.transform.Translate (0, 0.4f, 0);
		}

		if (direction.Equals ("down")) {
			erik.transform.Translate (0, 0, 0);
		}
	}

}