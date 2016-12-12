﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lockbox : MonoBehaviour {
	public InventoryItem[] keys;
	public GameObject nextState;
	private int locksOpened = 0;

	void OnMouseDown(){
		for (int idx = 0; idx < keys.Length; idx++){
			if (keys [idx].isEquipped) {
				locksOpened++;
				keys [idx].UseUp ();
			}
		}

		if (locksOpened == keys.Length) {
			gameObject.SetActive (false);
			nextState.SetActive (true);
		}

	}

	void OnMouseEnter() {
		foreach (InventoryItem key in keys) {
			if (key.isEquipped) {
				GameData.MakeCursorPointer ();
				return;
			}
		}
			
	}

	void OnMouseExit() {
		GameData.MakeCursorNormal ();
	}
	
}
