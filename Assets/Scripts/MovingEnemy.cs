using UnityEngine;
using System.Collections;

public class MovingEnemy : Enemies {

	// Use this for initialization
	private GameObject enemy;
	// Use this for initialization
	void Start () {
		enemy = GameObject.Find ("MovingEnemy");
	}

	// Update is called once per frame
	void Update () {
		enemy.transform.Translate (-0.1f, 0, 0);
	}
}
