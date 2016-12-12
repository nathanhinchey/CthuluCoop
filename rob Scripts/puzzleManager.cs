using UnityEngine;
using System.Collections;

public class puzzleManager : MonoBehaviour {


	public InteractableScript dresser;
	public InteractableScript dresserDrawer;
	public InteractableScript unZoomFridge;
	public InteractableScript bedPillow;
	public InteractableScript key1;
	public InteractableScript key2;
	public InteractableScript lockBox;
	public InteractableScript hammer;
	public InteractableScript dog;
	public InteractableScript cat;
	public InteractableScript doorArea;
	public InteractableScript bookShelf;
	public InteractableScript roman1Button;
	public InteractableScript roman2Button;
	public InteractableScript roman3Button;
	public InteractableScript candles;
	public InteractableScript altar;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (dresserDrawer.touched == true) 
		{
			Debug.Log ("Is touched");
		}
	
	}
}
