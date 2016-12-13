using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHeaderText : MonoBehaviour {
	// Put this on anything that's changing the email app header text when clicked

	public string newHeaderText;

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			SetEmailHeaderText ();
		});
	}

	void SetEmailHeaderText () {
		GameData.emailAppHeader.text = newHeaderText;
	}
}
