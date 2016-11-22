using UnityEngine;
using System.Collections;

public class RotatingEnemy : Enemies {
	private GameObject rotateEnemy;
	// Use this for initialization
	void Start () {
		rotateEnemy = GameObject.Find ("RotatingEnemy");
	}
	
	// Update is called once per frame
	void Update () {
		rotateEnemy.transform.Rotate (0, 0, 2f);
	}
}
