using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffectRoom : MonoBehaviour {
	// Used to manipulate game objects in the main view from the zoomed in view
	// For example, when you open the drawer in the zoomed in view, the drawer
	// will be open in the zoomed out view.

	// enter number in inspector, then drag in relevant GOs;
	// these will be deactivated.
	public GameObject[] nonTargetGOs; // (array of GameObjects)

	// Drag a GO here in the inspector. It will be activated.
	public GameObject targetGO;

	// Activate all that stuff when this sprite is clicked on
	void OnMouseDown(){
		foreach (GameObject go in nonTargetGOs) {
			go.SetActive (false);
		}
		targetGO.SetActive (true);
	}
}
