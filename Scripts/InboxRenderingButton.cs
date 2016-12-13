using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InboxRenderingButton : MonoBehaviour {
	public EmailApp emailApp;

	void Start(){
		gameObject.GetComponent<Button> ().onClick.AddListener (delegate {
			emailApp.RenderInboxEmails();
		});
	}
}
