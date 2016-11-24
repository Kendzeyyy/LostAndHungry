using UnityEngine;
using System.Collections;

public class FloorGenerator : MonoBehaviour {

	public GameObject obstacle;

	// floor generation start point
	float x = 0;

	void Update () {

		// obstacles min & max height
		float y = Random.Range(-11.03f, -11.03f);

		// amount of floor created
		if(x < 200) {
			Instantiate(obstacle, new Vector3(x * 10.0f, y, 0),Quaternion.identity);
			x++;
		}
		Debug.Log(x);
	}
}