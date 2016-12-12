using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour {

	public List<Interaction> interactionOptions;

	public void OnMouseEnter(){
		GameData.MakeCursorPointer();
	}

	public void OnMouseExit(){
		GameData.MakeCursorNormal();
	}
}
