using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKeysOffFridge : MonoBehaviour {
	// This is to collect the keys that are on the fridge. It's just attached to a single
	// invisible sprite.

	public GameObject roomKeyhider; // the sprite hiding the keys in the room (this is a hack)
	public GameObject zoomKeyhider; // the sprite hiding the keys in the zoom (this is a hack)
	public GameObject keys; // the keys from your inventory

	void OnMouseDown(){
		roomKeyhider.SetActive (true);
		zoomKeyhider.SetActive (true);
		keys.SetActive (true);
		gameObject.SetActive (false);
	}
}
