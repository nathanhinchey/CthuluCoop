using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHeaderText : MonoBehaviour {
	public string newHeaderText;

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			SetEmailHeaderText ();
		});
	}
	
	// Update is called once per frame
	void SetEmailHeaderText () {
		GameData.emailAppHeader.text = newHeaderText;
	}
}
