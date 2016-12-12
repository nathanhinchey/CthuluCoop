using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour {
	public static GameObject player;
	public static Transform singleEmailContainer;
	public static Text emailAppHeader;

	// All quests in the game (not sure what this will be used for)
	public static List<Quest> quests;

	// Values for status bars
	public static float mentalScore;
	public static float physicalScore;
	public static float financialScore;

	public static Dictionary<string, Text> singleEmailScreen = new Dictionary<string, Text> ();

	public Text singleEmailSubject;
	public Text singleEmailSender;
	public Text singleEmailTime;
	public Text singleEmailBody;

	public Transform singleEmail;

	public Text emailHeader;

	public static Texture2D cursorPointer;
	public Texture2D cursorPointerTexture;
	public static Texture2D cursorDefault;
	public Texture2D cursorDefaultTexture;

	public static GameObject activeZoomView;

	public static GameObject zoomViewPane;
	public GameObject zoomPane;

	public static bool hasCrowbar = false;
	public static bool hasCandles = false;
	public static bool hasCrossKey = false;
	public static bool hasSkeletonKey = false;

	void Start(){

		// email app
		singleEmailScreen.Add ("subject", singleEmailSubject);
		singleEmailScreen.Add ("sender", singleEmailSender);
		singleEmailScreen.Add ("time", singleEmailTime);
		singleEmailScreen.Add ("body", singleEmailBody);
		singleEmailContainer = singleEmail;
		emailAppHeader = emailHeader;

		// cursor
		cursorPointer = cursorPointerTexture;
		cursorDefault = cursorDefaultTexture;
		MakeCursorNormal ();

		// zoom
		zoomViewPane = zoomPane;
	}

	public static void MakeCursorPointer(){
		Cursor.SetCursor(cursorPointer, Vector2.zero, new CursorMode());
	}

	public static void MakeCursorNormal(){
		Cursor.SetCursor(cursorDefault, Vector2.zero, new CursorMode());
	}

}
