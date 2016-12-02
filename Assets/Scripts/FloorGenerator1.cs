using UnityEngine;
using System.Collections;

/*
Generates any given objects into the game randomly, between the given values.
This script is meant to create floor in to levels.
Attach floor object into this script in Unity.
author: Ahlström
*/

public class FloorGenerator1 : MonoBehaviour {

	public GameObject floor;

	// floor generation start point
	float x = 12;

	void Update () {

		// obstacles min & max height
		float y = Random.Range(163f, 163f);

		// amount of floor created amd distance between them
		if(x < 2200) {
			Instantiate(floor, new Vector3(x * 250.0f, y, 0),Quaternion.identity);
			x++;
		}
		//Debug.Log(x);
	}
}