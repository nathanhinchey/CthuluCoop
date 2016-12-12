using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class UIInteractable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public void OnPointerEnter(PointerEventData eventData){
		Debug.Log ("OnPointerEnter");
		GameData.MakeCursorPointer();
	}

	public void OnPointerExit(PointerEventData eventData){
		GameData.MakeCursorNormal();
	}
}

