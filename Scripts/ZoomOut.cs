using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour {
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
