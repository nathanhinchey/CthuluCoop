using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {
	public string title;
	public string text;

	public Quest(string title, string text){
		this.title = title;
		this.text = text;
	}
}
