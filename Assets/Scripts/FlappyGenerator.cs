using UnityEngine;
using System.Collections;

public class SpawnObstacle : MonoBehaviour {

	public GameObject obstacle;
	float x = 0;

	void Update () {
		float y = Random.Range(15.43331f, 29.42488f);
		if(x < 1000) {
			Instantiate(obstacle, new Vector3(x * 6.0f, y, 0),Quaternion.identity);
			x++;
		}
		Debug.Log(x);
	}
}