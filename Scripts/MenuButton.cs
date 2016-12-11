using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

	public Transform cellPhone;
	public Transform targetScreen;

	// Use this for initialization
	void Start(){
		Debug.Log ("Start");
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			GoHome ();
		});
	}

	void GoHome(){
		cellPhone.DetachChildren ();
		Debug.Log ("triggered?");
		targetScreen.SetParent (cellPhone);
	}
}
