using UnityEngine;
using System.Collections;

// Kameran seuraus
// Author: Jenna Kopra

public class CameraFollow2 : MonoBehaviour {

	public GameObject targetErik;									//Erikin hahmo


	// Kutsutaan kerran framessa
	void Update () {
		float targetObjectX = targetErik.transform.position.x;		//Kertoo mikä on targetObjectX
		Vector3 newCameraPosition = transform.position;				// Kertoo mikä on newCameraPosition
		newCameraPosition.x = targetObjectX+=600;					// Seuraa kohdetta Erik + 600 sivuttain, jotta Erik ei olisi kuvan keskellä
		transform.position = newCameraPosition;						// Liikuttaa kameraa

	}
}
