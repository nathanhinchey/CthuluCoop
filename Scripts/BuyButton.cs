using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour {

	public GameObject item;

	void Purchase(){
		item.SetActive (true);
	}
}
