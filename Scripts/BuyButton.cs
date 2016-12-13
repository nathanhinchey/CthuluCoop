using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour {
	// This is just the script for buying the crowbar.

	public GameObject item; // The InventoryItem that you're buying
	public GameObject newPage; // the page with "sold out" on the crowbar; set in inspector

	// I'm not certain why this works, but it seems to be needed in any button-based script
	// I've just copied and pasted it, and replaced the line with what funtion to invoke
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			Purchase (); // replace this when you copy and paste
		});
	}

	void Purchase(){
		item.SetActive (true); // activate the hidden item
		if (newPage) {
			gameObject.SetActive (false); // hide this screen
			newPage.SetActive (true); // replace it with a different screen
		}
	}


}
