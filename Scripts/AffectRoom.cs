using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffectRoom : MonoBehaviour {

	public GameObject[] nonTargetGOs;
	public GameObject targetGO;

	void OnMouseDown(){
		foreach (GameObject go in nonTargetGOs) {
			go.SetActive (false);
		}
		targetGO.SetActive (true);
	}
}
