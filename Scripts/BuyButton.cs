using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour {

	public GameObject item;
	public GameObject newPage;

	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			Purchase ();
		});
	}

	void Purchase(){
		Debug.Log (item);
		item.SetActive (true);
		if (newPage) {
			gameObject.SetActive (false);
			newPage.SetActive (true);
		}
	}


}
