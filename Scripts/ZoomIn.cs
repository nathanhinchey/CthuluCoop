using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour {
	// attach this to any object that, when clicked, zooms in

	public GameObject zoomView; // this is a view nested under ZoomViews in the heirarchy
	GameObject zoomPane;

	void OnMouseDown(){

		zoomPane = GameData.zoomViewPane;

		// close the existing zoom view if necessary
		if (GameData.activeZoomView) {
			GameData.activeZoomView.SetActive (false);
		}

		// activate your chosen zoom view
		GameData.activeZoomView = zoomView; // tell GameData that you're zooming in
		zoomPane.SetActive (true); // show the zoom GameObject
		zoomView.SetActive (true); // show the selected view
	}
}
