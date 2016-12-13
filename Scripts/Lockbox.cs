using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lockbox : MonoBehaviour {
	// Used for any container that needs a special kind of device to open it
	// NOTE: keys is an array because I thought there would be a box with two keys, where you have to
	// unock each of them.

	public InventoryItem[] keys; // Set this to 1 and drag the key (or crowbar) into the one slot
	public GameObject nextState; // what you unlock
	private int locksOpened = 0;
	private AffectRoom affectRoom;

	void Start(){
		// Don't let this change the main room unless you have the key
		affectRoom = gameObject.GetComponent<AffectRoom> ();
		if (affectRoom) {
			affectRoom.enabled = false;
		}
	}

	void OnMouseDown(){
		for (int idx = 0; idx < keys.Length; idx++){
			if (keys [idx].isEquipped) {
				locksOpened++;
				keys [idx].UseUp ();
			}
		}

		if (locksOpened == keys.Length) { // if all the locks are unlocked, open up
			gameObject.SetActive (false);
			nextState.SetActive (true);
		}

	}

	// have a pointer if and only if you have the right key
	void OnMouseEnter() {
		foreach (InventoryItem key in keys) {
			if (key.isEquipped) {
				GameData.MakeCursorPointer ();
				if (affectRoom) {
					affectRoom.enabled = true; // be able to change the main room
				}
				return;
			}
		}
			
	}

	// turn off pointer cursor when done
	void OnMouseExit() {
		GameData.MakeCursorNormal ();
		if (affectRoom) {
			affectRoom.enabled = false;
		}
	}
	
}
