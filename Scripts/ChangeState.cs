using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour {
	// Used to cycle through positions of a single thing
	// For example, the several cats game objects are basically one cat, with different states,
	// and you use this to cylce through them

	public GameObject nextState; // whatever GameObject you want to pop up when this one goes away
	
	public void BecomeNextState(){
		gameObject.SetActive (false); // hide this GO
		nextState.SetActive (true); // show the nextState GO
	}

	void OnMouseDown(){
		BecomeNextState ();
		GameData.MakeCursorNormal (); // this won't happen automatically, so I'm triggering it manually
	}
}
