using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailApp : MonoBehaviour {
	public RectTransform inboxEmailSection;
	public GameObject emailPrefab;
	private Vector3 position; 

	public List<Dictionary<string, string>> emails = new List<Dictionary<string, string>>();

	void Start () {
		Dictionary<string, string> e1 = new Dictionary<string, string>();
		e1.Add("subject", "Talk to your cat in the third person.");
		e1.Add("body", "This is a call from your senator. It is urgent that you talk to your cat RIGHT NOW.");
		e1.Add("sender", "Senator Doom");
		e1.Add("time", "Dec 22");

		emails.Add (e1);

		Dictionary<string, string> e2 = new Dictionary<string, string>();
		e2.Add("subject", "Dogs are weird");
		e2.Add("body", "Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores Lorem Ipsum Dolores ");
		e2.Add("sender", "Lorem McIpsum");
		e2.Add("time", "Dec 23");

		emails.Add (e2);

		RenderInboxEmails ();
	}

	void RenderInboxEmails () {
		inboxEmailSection.SetSiblingIndex (9999);
		for (int i = 0; i < emails.Count; i++) {
			position = new Vector3 (0, -100f * i, 0);

			GameObject currentEmail = Instantiate (emailPrefab, Vector3.zero, Quaternion.identity);
			InboxEmail emailScript = currentEmail.GetComponent ( typeof(InboxEmail)) as InboxEmail;
			emailScript.subject = emails [i]["subject"];
			emailScript.body = emails [i]["body"];
			emailScript.time = emails [i]["time"];
			emailScript.sender = emails [i]["sender"];

			RectTransform currentEmailTransform = currentEmail.GetComponent<RectTransform> ();

			currentEmailTransform.SetParent (inboxEmailSection);
			currentEmailTransform.anchorMin = new Vector2 (1, 1);
			currentEmailTransform.anchorMin = new Vector2 (1, 1);
			currentEmailTransform.localScale = new Vector3 (1, 1, 1);
			currentEmailTransform.localPosition = position;

			emailScript.RenderForInbox ();
		}
		Vector2 inboxEmailSectionDimensions;
		if (emails.Count <= 5) {
			inboxEmailSectionDimensions = new Vector2 (400, 550);
		} else {
			inboxEmailSectionDimensions = new Vector2 (400, emails.Count * 100 + 50);
		}
		inboxEmailSection.sizeDelta = inboxEmailSectionDimensions;
	}
}
