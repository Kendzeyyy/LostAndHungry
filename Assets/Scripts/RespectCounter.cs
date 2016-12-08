using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
Point counter script for every level except fot jetlevel. Check RespectCounterJet.cs.
Attach this script to the player in Unity.
Author: Mikael Ahlström
*/
 
public class RespectCounter : MonoBehaviour {
 
    private float score = 0.0f;
 
    public Text scoreText;
    private bool isDead = false;
    public DeathMenu deathMenu;
 
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update () {
 
        if(isDead) {
            return;
        }
 
        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString();
    }
    
    // This method is called in ErikController.cs
    public void OnDeath() {
        isDead = true;
        deathMenu.ToggleEndScore (score);
    }
}