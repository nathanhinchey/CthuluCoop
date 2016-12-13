using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour {
	// Used for hiding the current screen in favor of a different screen
	// I'm using "screen" here because this is mostly for the cell phone
	// NOTE: any GO this is on must also have a Button component

	public Transform targetScreen; // the screen your button opens

	// Use this for initialization
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			LoadTargetScreen ();
		});
	}

	void LoadTargetScreen(){
		targetScreen.SetSiblingIndex (9999); //bring the target screen to the front
	}

}
