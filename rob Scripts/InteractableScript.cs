using UnityEngine;
using System.Collections;

public class InteractableScript : MonoBehaviour {

	public bool touched;
	public GameObject newScreen;

	public void OnMouseDown () 
	{
		touched = !touched;

		if (newScreen != null)
		{
			newScreen.SetActive (true);
		}
	}
}


