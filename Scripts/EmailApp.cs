using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailApp : MonoBehaviour {
	// Attached the the email app in the cell phone

	public RectTransform inboxEmailSection; // the area where emails will be listed
	public GameObject emailPrefab; // the email prefab from the prefabs directory
	private Vector3 position;

	public List<Dictionary<string, string>> emails = new List<Dictionary<string, string>>();

	void Start () {
		AddFirstEmailBatch ();
	}

	// Put first batch of emails here
	void AddFirstEmailBatch() {
		Dictionary<string, string> e1 = new Dictionary<string, string>();
		e1.Add("subject", "Subject of the email");
		e1.Add("body", "Body of the email");
		e1.Add("sender", "Name of the sender");
		e1.Add("time", "The date sent (yeah, this variable is named wrong)");
		emails.Add(e1); //This adds them to the email list
	}

	// Put second batch of emails here
	// this will get triggered at some point?
	void AddSecondEmailBatch () {
	}

	// Put third batch of emails here
	// this will get triggered at some point?
	void AddThirdEmailBatch() {
	}

	// populates the inbox with emails
	public void RenderInboxEmails () {
		inboxEmailSection.SetSiblingIndex (9999); // bring the inbox section to the front of the email app
		for (int i = 0; i < emails.Count; i++) {

			// Set the text values for the emails
			GameObject currentEmail = Instantiate (emailPrefab, Vector3.zero, Quaternion.identity);
			InboxEmail emailScript = currentEmail.GetComponent ( typeof(InboxEmail)) as InboxEmail;
			emailScript.subject = emails [i]["subject"];
			emailScript.body = emails [i]["body"];
			emailScript.time = emails [i]["time"];
			emailScript.sender = emails [i]["sender"];

			// figure out where the email is gonna go
			position = new Vector3 (0, -100f * i, 0);

			// Position the emails correctly
			RectTransform currentEmailTransform = currentEmail.GetComponent<RectTransform> ();

			currentEmailTransform.SetParent (inboxEmailSection);
			currentEmailTransform.anchorMin = new Vector2 (1, 1);
			currentEmailTransform.anchorMin = new Vector2 (1, 1);
			currentEmailTransform.localScale = new Vector3 (1, 1, 1);
			currentEmailTransform.localPosition = position;

			emailScript.RenderForInbox (); // invoke the function from InboxEmail
		}

		// This section sets the size of the (scrollable) list of inbox emails
		// based on how many emails you have
		Vector2 inboxEmailSectionDimensions;
		if (emails.Count <= 5) {
			inboxEmailSectionDimensions = new Vector2 (400, 550); //minimum of 550px
		} else {
			inboxEmailSectionDimensions = new Vector2 (400, emails.Count * 100 + 50); //
		}
		inboxEmailSection.sizeDelta = inboxEmailSectionDimensions;
	}
}
