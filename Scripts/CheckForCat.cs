using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCat : MonoBehaviour {
	public GameObject fridgeCat;
	public GameObject doglessFridge;
	
	// Update is called once per frame
	void Update () {
		if (fridgeCat.activeInHierarchy) {
			gameObject.SetActive (false);
			doglessFridge.SetActive (true);
		}
	}
}
