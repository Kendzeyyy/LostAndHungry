using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject Enemies;
	float maxSpawnRate = 0.1f;
	// Use this for initialization
	void Start () {
		Invoke ("SpawnEnemy", maxSpawnRate);
	}
	
	// Update is called once per frame
	void Update () {
		
}
	void SpawnEnemy()
	{
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		GameObject anEnemy = (GameObject)Instantiate (Enemies);
		anEnemy.transform.position = new Vector2 (Random.Range (min.x, max.x), max.y);
	}
}
