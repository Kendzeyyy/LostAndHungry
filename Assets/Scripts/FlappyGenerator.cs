﻿using UnityEngine;
using System.Collections;

public class FlappyGenerator : MonoBehaviour {

	public GameObject obstacle;

	// obstacle generation start point
	float x = 6;

	void Update () {

		// obstacles min & max height
		float y = Random.Range(-69.3f, -56.7f);

		// amount of generated obstacles and point counter
		if(x < 200) {
			Instantiate(obstacle, new Vector3(x * 10.0f, y, 0),Quaternion.identity);
			x++;
		}
		Debug.Log(x);
	}
}