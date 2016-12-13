using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour {
	// This is the way to exit from zoom in. Right now it's just attached to
	// a bunch of colliders around the zoom view, so you exit by clicking off the zoomed in panel
	GameObject zoomPane;

	void OnMouseDown(){
		zoomPane = GameData.zoomViewPane;
		zoomPane.SetActive (false);
		GameData.MakeCursorNormal();
		if (GameData.activeZoomView) {
			GameData.activeZoomView.SetActive (false);
			GameData.activeZoomView = null;
		}
	}
}
