using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {
	public string title;
	public string description;
	public float financialEffect;
	public float physicalEffect;
	public float mentalEffect;

	public Quest(string title) {
		this.title = title;
	}
}
