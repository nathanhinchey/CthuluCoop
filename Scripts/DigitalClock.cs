using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DigitalClock : MonoBehaviour {
	private Text timeFromClock;
	private string hour;
	private string minute;

	void Start () {
		timeFromClock = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		minute = Clock.GameHour.ToString ();
		hour = Clock.GameMinute.ToString ();
		// pad a 0 in front of single digit minutes
		hour = (hour.Length > 1) ? (hour) : ("0" + hour);
		timeFromClock.text = minute + ":" + hour;
	}
}