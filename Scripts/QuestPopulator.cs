using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPopulator : MonoBehaviour {

	public static List<Quest> PopulateQuests(){
		List<Quest> quests = new List<Quest>();

		Quest callMom = new Quest ("Call Mom");
		callMom.financialEffect = 10f;
		callMom.mentalEffect = -5f;
		callMom.physicalEffect = 0f;
		callMom.description = "Call your mother! It's been way too long.";
		quests.Add (callMom);

		return quests;
	}
}
