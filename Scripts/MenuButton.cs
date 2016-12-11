using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

	public Transform phoneScreen;
	public Transform targetScreen;

	// Use this for initialization
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			GoHome ();
		});
	}

	void GoHome(){
		foreach (Transform child in phoneScreen.transform) {
			child.gameObject.SetActive (false);
		}
		targetScreen.gameObject.SetActive (true);
	}
}
