using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	Rigidbody2D myBody;

	public int movementspeed;
	public int jumpForce;
	float moveVelocity;


	void Start () {
		myBody = GetComponent<Rigidbody2D> ();
		}

	void Update () {
		}

	void OnCollisionEnter2D(Collision2D col){
	}

	public void playerMove (){
		myBody.velocity = new Vector2 (movementspeed, myBody.velocity.y);

	}

	public void playerJump (){
		myBody.AddForce (transform.up * jumpForce);

	}
}


