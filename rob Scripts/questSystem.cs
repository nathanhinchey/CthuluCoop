//using UnityEngine;
//using System.Collections;
//
//public class questSystem : MonoBehaviour {
//
//	public Rect questWindowSize = new Rect (15, 15, 250, 250);
//	public string questTitle;
//	public string questDesc;
//	public string positiveText;
//	public string negativeText;
//	public int textPosX;
//	public int textPosY;
//	public int textSizeX;
//	public int textSizeY;
//
//
//
//	// Use this for initialization
//	private void OnGUI ()
//	{
//
//		GUI.Window (0, questWindowSize, MyWindow, questTitle, image: Sprite);
//	
//	}
//	
//	private void MyWindow (int id)
//	{
//		GUI.TextArea (new Rect (textPosX, textPosY, textSizeX, textSizeY), questDesc);
//		GUI.Button (new Rect (15, 15, 50, 50), positiveText);
//	}
//
//
//}
