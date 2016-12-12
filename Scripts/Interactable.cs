using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

	public List<Interaction> interactionOptions;

	public void OnMouseEnter(){
		Debug.Log ("mouseenter interactable");
		GameData.MakeCursorPointer();
	}

	public void OnMouseExit(){
		Debug.Log ("mouseexit interactable");
		GameData.MakeCursorNormal();
	}
}
