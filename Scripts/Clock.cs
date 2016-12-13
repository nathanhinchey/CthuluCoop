using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {
	// NOT ACTIVE ANYWHERE IN CURRENT VERSION

	public RectTransform hourHand;
	public RectTransform minuteHand;
	public float clockSpeedFactor = 1;
	public float clockDefaultSpeed = 1;

	// This is an accessor: it prevents the private variable from being modified,
	// while making its value available.
	private static float gameTime;
	public static float GameTime { get { return gameTime; }}

	private static float gameHour;
	public static int GameHour { get { return Mathf.FloorToInt(gameHour); }}

	private static float gameMinute;
	public static int GameMinute { get { return Mathf.FloorToInt(gameMinute); }}

	// Use this for initialization
	void Start () {
		gameTime = 0f;
	}

	private float hourAngle {
		get { return gameHour * -30; }
	}

	private float minuteAngle {
		get { return gameMinute * -6; }
	}

	private void CalculateMinuteAndHour(){
		gameHour = (Clock.GameTime) % 12;
		if (gameHour == 0) { gameHour = 12; }
		gameMinute = (Clock.GameTime - Mathf.Floor(Clock.GameTime)) * 60;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameTime += clockDefaultSpeed * clockSpeedFactor;

		CalculateMinuteAndHour ();

		minuteHand.rotation = Quaternion.Euler (0f, 0f, minuteAngle);
		hourHand.rotation = Quaternion.Euler (0f, 0f, hourAngle);
	}
}
