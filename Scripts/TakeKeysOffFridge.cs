using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKeysOffFridge : MonoBehaviour {

	public GameObject roomKeyhider;
	public GameObject zoomKeyhider;
	public GameObject keys;

	void OnMouseDown(){
		roomKeyhider.SetActive (true);
		zoomKeyhider.SetActive (true);
		keys.SetActive (true);
		gameObject.SetActive (false);
	}
}
