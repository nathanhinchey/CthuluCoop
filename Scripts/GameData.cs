using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {
	public static GameObject player;

	// All quests in the game (not sure what this will be used for)
	public static List<Quest> quests;

	// Values for status bars
	public static float mentalScore;
	public static float physicalScore;
	public static float financialScore;
}
