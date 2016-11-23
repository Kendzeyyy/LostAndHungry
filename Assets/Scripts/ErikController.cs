using UnityEngine;
using System.Collections;

public class ErikController : MonoBehaviour
{
	private ButtonController upButton;
	//private ButtonController downButton;
	private Animator animator;
	public float erikSpeed;
	private bool dead = false;
	private GameObject erik;




	void Start ()
	{

		animator = GetComponent<Animator>();
		//downButton = GameObject.Find ("DownButton").GetComponent<ButtonController> ();
		upButton = GameObject.Find ("UpButton").GetComponent<ButtonController> ();
		erik = GameObject.Find ("ErikPlayer");

	}

	// Update is called once per frame
	void Update () {

		if (dead == false) {
			erik.transform.Translate (0.20f, 0, 0);
		}
			if (upButton.GetPressed ()) {
				MoveErik ("up");
			}
			//if (downButton.GetPressed ()) {
			//	MoveErik ("down");
			//}
		}


	void MoveErik (string direction)
	{
	
	
		if (dead == false) {
	
			Debug.Log ("move " + direction);


			if (direction.Equals ("up")) {
				erik.transform.Translate (0, 0.4f, 0);
			}

			if (direction.Equals ("down")) {
				erik.transform.Translate (0, 0, 0);
			}
		}

	}
	public void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Enemy") {
		animator.SetInteger ("die", 3);

		dead = true;
		Debug.Log ("Hit");

	}

}
}