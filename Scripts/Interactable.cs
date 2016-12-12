using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

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
