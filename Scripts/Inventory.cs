using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public static InventoryItem activeItem;

	// Use this for initialization
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			UnequipActiveItem ();
		});
	}

	void UnequipActiveItem(){
		if (activeItem) {
			activeItem.Unequip();
		}
	}
}
