using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour {
	// This is the script for any tool you collect.

	// This is where the item will return to when dropped;
	// You should probably manually set it in the inspector to be the same as its position
	public Vector3 startingPosition; 
	public bool isEquipped = false;

	void Start(){
		// same magic clickable thingy for UI
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			Equip ();
		});
		transform.localPosition = startingPosition; // This doesn't seem to work; not sure why
	}

	// Start carrying the item for use
	void Equip(){
		Inventory.activeItem = this;
		isEquipped = true;
	}

	// Put the item back in the inventory
	public void Unequip() {
		Inventory.activeItem = null;
		isEquipped = false;
		transform.localPosition = startingPosition;
	}

	// get rid of the item (for one time use items, which all our items are)
	public void UseUp(){
		Unequip ();
		gameObject.SetActive (false);
	}

	void Update () {
		// follow the mouse when equipped. -100 is so you aren't clicking on it
		if (isEquipped) {
			transform.position = Input.mousePosition + new Vector3(0,-100,0);
		}
	}
}
