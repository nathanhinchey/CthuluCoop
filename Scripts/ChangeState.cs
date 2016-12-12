using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour {

	public GameObject nextShape;
	
	public void BecomeNextState(){
		gameObject.SetActive (false);
		nextShape.SetActive (true);
	}

	void OnMouseDown(){
		BecomeNextState ();
	}
}
