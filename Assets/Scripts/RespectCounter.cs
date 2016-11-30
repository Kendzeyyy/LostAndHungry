using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RespectCounter : MonoBehaviour {

	private float score = 0.0f;

	public Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
		scoreText.text = ((int)score).ToString();
	
	}
}
