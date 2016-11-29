using UnityEngine;
using System.Collections;

/*
Generates any given objects into the game randomly, between the given values.
Attach any GameObject into this script in Unity.
author: Ahlström
*/

public class FlappyGenerator : MonoBehaviour {

	public GameObject obstacle;

	// Obstacle generation start point.
	float x = 6;

	void Update () {

		// Obstacles min & max height. All objects created inside these values.
		float y = Random.Range(-16f, -555f);

		// Sets the max amount of generated obstacles and space between them.
		if(x < 200) {
			Instantiate(obstacle, new Vector3(x * 500.0f, y, 0),Quaternion.identity);
			x++;
		}
		Debug.Log(x);
	}
}