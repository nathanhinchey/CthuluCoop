using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

	public Transform targetScreen;

	// Use this for initialization
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			LoadTargetScreen ();
		});
	}

	void LoadTargetScreen(){
		targetScreen.SetSiblingIndex (9999);
	}
}
