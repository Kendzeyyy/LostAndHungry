using UnityEngine;
using System.Collections;


// pyörivien vihollisten ohjain
// Author: Jenna Kopra

public class RotatingEnemy : Enemies {									// perii enemies classin

	PauseGame pause;


	void Start (){
		pause = FindObjectOfType<PauseGame> ();

	}


	void Update () {													// päivittää kerran framessa


		if (!pause.esimerkki) {
			gameObject.transform.Rotate (0, 0, 2f);

		}
	}
}
