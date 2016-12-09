﻿using UnityEngine;
using System.Collections;


// Camera
// Author: Jenna Kopra

public class CameraFollow1 : MonoBehaviour {

	public GameObject targetErik;									//Erik's characther

	
																	
	void Update () {
		float targetObjectX = targetErik.transform.position.x;		//Tells what is targetObjectX
		Vector3 newCameraPosition = transform.position;				// Tells what is newCameraPosition
		newCameraPosition.x = targetObjectX+=11;					// follows Erik + 11 x, so that erik is not in the center of the screen
		transform.position = newCameraPosition;						// moves the camera
	
	}
}
