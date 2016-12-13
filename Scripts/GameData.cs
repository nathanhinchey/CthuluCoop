using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour {
	// Holds onto stuff we need elsewhere
	// I attached a copy of it to the MainCamera so it can reference game objects

	// This is the view for when you click on an email in the email app on the phone
	public Transform singleEmail; // set it in inspector
	public static Transform singleEmailContainer; // use this in scripts

	// This is the text that says "inbox" or "< back to inbox"
	public Text emailHeader; // set it in inspector
	public static Text emailAppHeader; // use this in scripts

	// Holding onto these in a dictionary
	// set these in the inspector:
	public Text singleEmailSubject;
	public Text singleEmailSender;
	public Text singleEmailTime;
	public Text singleEmailBody;
	//reference this in scripts:
	public static Dictionary<string, Text> singleEmailScreen = new Dictionary<string, Text> ();

	// Values for status bars (currently unused)
	public static float mentalScore;
	public static float physicalScore;
	public static float financialScore;

	// Cursors to indicate what is clickable: pointer = clickable, default = not clickable
	public Texture2D cursorPointerTexture; // set in inspector
	public static Texture2D cursorPointer; // use in scripts
	public Texture2D cursorDefaultTexture; // set in inspector
	public static Texture2D cursorDefault; // use in scripts

	// The view that we're currently zoomed in on
	public static GameObject activeZoomView; // use in scripts

	// The game object that the zoom stuff is on 
	public GameObject zoomPane; // set in inspector
	public static GameObject zoomViewPane; // use in scripts

	// This is just taking the game objects we set in the inspector and assigning them to
	// static variables so we can access them without a reference to any particular instance
	// of the GameData class
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

	// used by the Interactable and Lockbox scripts
	public static void MakeCursorPointer(){
		Cursor.SetCursor(cursorPointer, Vector2.zero, new CursorMode());
	}

	// used by the Interactable and Lockbox scripts
	public static void MakeCursorNormal(){
		Cursor.SetCursor(cursorDefault, Vector2.zero, new CursorMode());
	}

}
