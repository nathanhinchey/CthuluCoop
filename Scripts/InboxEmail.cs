using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InboxEmail : MonoBehaviour {
	// This is for the email prefab and you probably won't have to touch it.

	public Text subjectInbox, senderInbox, timeInbox; 
	public Text subjectSingle, senderSingle, timeSingle, bodySingle;
	public string subject, sender, body, time;
	public bool isRead = false;


	private Transform singleEmailContainer, viewportContent;

	// Use this for initialization
	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			OpenEmail ();
		});
	}

	// render this email's summary (does not handle positioning)
	public void RenderForInbox(){

		if (this.isRead) {
			Text[] textElements = transform.GetComponentsInChildren<Text> ();
			foreach (Text textElement in textElements) {
				textElement.color = new Color (0.5f, 0.5f, 0.5f);
			}
		}
		subjectInbox.text = subject;
		senderInbox.text = sender;
		timeInbox.text = time;
	}

	// render the long form of this email (handles positioning)
	void OpenEmail(){

		subjectSingle = GameData.singleEmailScreen ["subject"];
		senderSingle = GameData.singleEmailScreen ["sender"];
		timeSingle = GameData.singleEmailScreen ["time"];
		bodySingle = GameData.singleEmailScreen ["body"];

		singleEmailContainer = GameData.singleEmailContainer;

		subjectInbox.text = this.subject;
		bodySingle.text = this.body;
		timeSingle.text = this.time;
		senderSingle.text = this.sender;
		singleEmailContainer.SetSiblingIndex (9999);
		isRead = true;
	}
}
