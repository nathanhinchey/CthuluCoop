using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
	// This goes on the inventory (right now the purple square on the bottom right of the canvas

	public static InventoryItem activeItem; // this is set when an object is picked up

	// just the same magic clickability thing. UnityEngine.UI is weird.
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			UnequipActiveItem (); 
		});
	}

	// invoke the Unequip method of the activeItem, if any item is active
	// Basically, put down whatever you're holding.
	void UnequipActiveItem(){
		if (activeItem) {
			activeItem.Unequip();
		}
	}
}
