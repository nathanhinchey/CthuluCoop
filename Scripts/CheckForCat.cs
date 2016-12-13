using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCat : MonoBehaviour {
	// This script is JUST for the dog hiding in your fridge.
	// It is attached only to the open fridge with a dog in it
	public GameObject fridgeCat; // the cat GameObject that scares the dog
	public GameObject doglessFridge; // the empty fridge after the dog runs away
	
	// Update is called once per frame
	void Update () {
		if (fridgeCat.activeInHierarchy) { //if the active cat is the one next to the fridge
			gameObject.SetActive (false);  //replace this dog-filled fridge...
			doglessFridge.SetActive (true); // ...with the dogless one
		}
	}
}
