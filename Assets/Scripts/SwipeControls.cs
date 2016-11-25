using UnityEngine;
using System.Collections;

// WIP
// This script is not ready and is not yet implemented into the game.

public class SwipeControl : MonoBehaviour {

//inside class
Vector2 firstPressPos;
Vector2 secondPressPos;
Vector2 currentSwipe;



public void Swipe()
{
	if(Input.touches.Length > 0)
	{
		Touch t = Input.GetTouch(0);
		if(t.phase == TouchPhase.Began)
		{
			//save began touch 2d point
			firstPressPos = new Vector2(t.position.x,t.position.y);
		}
		if(t.phase == TouchPhase.Ended)
		{
			//save ended touch 2d point
			secondPressPos = new Vector2(t.position.x,t.position.y);

			//create vector from the two points
			currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

			//normalize the 2d vector
			currentSwipe.Normalize();

			//swipe upwards
			if(currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
			{
				Debug.Log("up swipe");
			}
			//swipe down
			if(currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
			{
				Debug.Log("down swipe");
			}
		}
	}
}
}