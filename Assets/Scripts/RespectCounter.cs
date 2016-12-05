using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
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
 
    public void OnDeath() {
        isDead = true;
        deathMenu.ToggleEndScore (score);
    }
}