using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayTimeIncomplete : MonoBehaviour {
	private Text timeFromClock;
	private int hour;
	private int minute;

	void Start () {
		timeFromClock = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		timeFromClock.text = Clock.GameHour.ToString () + ":" + Clock.GameMinute.ToString ();
	}
}