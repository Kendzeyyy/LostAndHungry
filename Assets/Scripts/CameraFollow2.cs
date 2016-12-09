using UnityEngine;
using System.Collections;

// Camera
// Author: Jenna Kopra

public class CameraFollow2 : MonoBehaviour {

	public GameObject targetErik;									//Erik's characther


	// Kutsutaan kerran framessa
	void Update () {
		float targetObjectX = targetErik.transform.position.x;		//Tells what is targetObjectX
		Vector3 newCameraPosition = transform.position;				// Tells what is newCameraPosition
		newCameraPosition.x = targetObjectX+=600;					// follows Erik +  600x, so that erik is not in the center of the screen
		transform.position = newCameraPosition;						// moves the camera

	}
}
