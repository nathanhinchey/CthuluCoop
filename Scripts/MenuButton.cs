using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Transform targetScreen;

	// Use this for initialization
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			LoadTargetScreen ();
		});
	}

	void LoadTargetScreen(){
		targetScreen.SetSiblingIndex (9999);
	}

	public void OnPointerEnter(PointerEventData eventData){
		GameData.MakeCursorPointer();
	}

	public void OnPointerExit(PointerEventData eventData){
		GameData.MakeCursorNormal();
	}

}
