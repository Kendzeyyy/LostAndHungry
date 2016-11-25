using UnityEngine;
using System.Collections;


// pyörivien vihollisten ohjain
// Author: Jenna Kopra

public class RotatingEnemy : Enemies {									// perii enemies classin

	void Update () {													// päivittää kerran framessa
		gameObject.transform.Rotate (0, 0, 2f);							// pyörittää objectia
	}
}
