using UnityEngine;
using System.Collections;

public class CameraFollow1 : MonoBehaviour {

	public GameObject targetErik;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float targetObjectX = targetErik.transform.position.x;

		Vector3 newCameraPosition = transform.position;
		newCameraPosition.x = targetObjectX+=11;
		transform.position = newCameraPosition;
	
	}
}
