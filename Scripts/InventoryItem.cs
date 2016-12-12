using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour {
	public Vector3 startingPosition;
	public bool isEquipped = false;

	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			Equip ();
		});
		transform.localPosition = startingPosition;
	}

	void Equip(){
		Inventory.activeItem = this;
		isEquipped = true;
	}

	public void Unequip() {
		Inventory.activeItem = null;
		isEquipped = false;
		transform.localPosition = startingPosition;
	}

	public void UseUp(){
		Unequip ();
		gameObject.SetActive (false);
	}

	void Update () {
		if (isEquipped) {
			transform.position = Input.mousePosition + new Vector3(0,-100,0);
		}
	}
}
