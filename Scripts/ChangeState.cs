using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour {

	public GameObject nextState;
	
	public void BecomeNextState(){
		gameObject.SetActive (false);
		nextState.SetActive (true);
	}

	void OnMouseDown(){
		BecomeNextState ();
		GameData.MakeCursorNormal ();
	}
}
