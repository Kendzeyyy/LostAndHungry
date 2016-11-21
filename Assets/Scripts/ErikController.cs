using UnityEngine;
using System.Collections;

public class ErikController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollision2DEnter(Collision2D col) {
		Debug.Log (col.collider);
		transform.Translate (0, 1.0f, 0);
		col.collider.transform.Translate (0, 0.5f, 0);
	}
}
