using UnityEngine;
using System.Collections;

/*
Generates any given objects into the game randomly, between the given values.
This script is meant to create floor in to the JetPack level.
Attach floor object into this script in Unity.
author: Ahlström
*/

public class FloorGenerator : MonoBehaviour {

	public GameObject obstacle;

	// floor generation start point
	float x = 0;

	void Update () {

		// obstacles min & max height
		float y = Random.Range(-11.03f, -11.03f);

		// amount of floor created amd distance between them
		if(x < 200) {
			Instantiate(obstacle, new Vector3(x * 10.0f, y, 0),Quaternion.identity);
			x++;
		}
		Debug.Log(x);
	}
}