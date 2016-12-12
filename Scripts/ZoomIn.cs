using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour {

	public GameObject zoomView;
	GameObject zoomPane;

	void OnMouseDown(){

		zoomPane = GameData.zoomViewPane;

		if (GameData.activeZoomView) {
			GameData.activeZoomView.SetActive (false);
		}
		GameData.activeZoomView = zoomView;
		zoomPane.SetActive (true);
		zoomView.SetActive (true);
	}
}
