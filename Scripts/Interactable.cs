using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	// This just makes UI elements and colliders change the cursor to a pointer
	// Put this script on anything you want the user to know is interactable

	public List<Interaction> interactionOptions;

	public void OnMouseEnter(){
		GameData.MakeCursorPointer();
	}

	public void OnMouseExit(){
		GameData.MakeCursorNormal();
	}

	public void OnPointerEnter(PointerEventData eventData){
		GameData.MakeCursorPointer();
	}

	public void OnPointerExit(PointerEventData eventData){
		GameData.MakeCursorNormal();
	}
}
