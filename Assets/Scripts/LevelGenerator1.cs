using UnityEngine;
using System.Collections;

/*
Generates any given objects into the game randomly, between the given values.
Attach any GameObject into this script in Unity.
author: Ahlström
*/

public class LevelGenerator1 : MonoBehaviour {

	public GameObject enemy1;
	public GameObject enemy2;

	// enemy generation start point.
	float x = 2;

	void Start () {

		// amount of enemies created
		int counter = 0;
		while (counter<257){
			
		float lottery = Random.value;

		if(lottery <= 0.5) { 
		// enemys min & max height. All enemies created inside these values.
				float y = Random.Range(400f, 400f);

		// Sets the max amount of generated obstacles and space between them.
			Instantiate(enemy1, new Vector3(x * 2000.0f, y, 0),Quaternion.identity);
				counter++;
				x++;
		} else {
			// Obstacles min & max height. All objects created inside these values.
				float y = Random.Range(500f, 500f);

			// Sets the max amount of generated obstacles and space between them.
			Instantiate(enemy2, new Vector3(x * 2000.0f, y, 0),Quaternion.identity);
				counter++;
				x++;

		}
		}
		}
	}
